#這個作業主要是要測試修改[Order], [Order Details]，但關聯的Table還有[Employees], [Customers], [Shippers]

#步驟：
#1. 為了減少初始化資料，將[Employees], [Customers], [Shippers]測試資料事先建在測試DB
#2. 在 Background 先新增[Order]及[Order Details] ID=10248 的資料，確保有這筆資料可以Update
#3. When 調用Update測試
#4. AfterScenario再刪除一次[Order Details]及[Order] ID=10248 的資料，還原資料

#問題：
#1. 傳遞資料是用ViewModel，但實際只處理某幾個欄位?
#   假設：訂單送簽，簽核只能修改 UnitPrice, Discount, Quantity，但資料傳遞是用ViewModel
#   除了註解外有沒有較好的表達方式

Feature: 修改訂單

Background: 
	Given 資料庫Orders資料
	| OrderID | CustomerID | EmployeeID | OrderDate               | RequiredDate            | ShippedDate             | ShipVia | Freight | ShipName                  | ShipAddress        | ShipCity | ShipRegion | ShipPostalCode | ShipCountry |
	| 10248   | VINET      | 5          | 1996-07-04 00:00:00.000 | 1996-08-01 00:00:00.000 | 1996-07-16 00:00:00.000 | 3       | 32.38   | Vins et alcools Chevalier | 59 rue de l'Abbaye | Reims    | NULL       | 51100          | France      |
	And 資料庫Order Details資料
	| OrderID | ProductID | UnitPrice | Quantity | Discount |
	| 10248   | 11        | 14.00     | 12       | 0        |
	| 10248   | 72        | 34.80     | 5        | 0        |
	| 10248   | 42        | 9.80      | 10       | 0        |


Scenario: 我在訂單作業修改訂單資料(整張訂單修改)
	Given ViewModel-Orders參數
	| OrderID | CustomerID | EmployeeID | OrderDate               | RequiredDate            | ShippedDate             | ShipVia | Freight | ShipName                  | ShipAddress        | ShipCity | ShipRegion | ShipPostalCode | ShipCountry |
	| 10248   | VINET      | 5          | 1996-07-04 00:00:00.000 | 1996-08-01 00:00:00.000 | 1996-07-16 00:00:00.000 | 3       | 32.38   | Vins et alcools Chevalier | 59 rue de l'Abbaye | Reims    | NULL       | 51100          | France      |
	And ViewModel-Order Details參數
	| OrderID | ProductID | UnitPrice | Quantity | Discount |
	| 10248   | 11        | 14.00     | 15       | 0        |
	| 10248   | 72        | 34.80     | 15       | 0        |
	| 10248   | 42        | 9.80      | 15       | 0        |
	When 我調用Update
	Then 我會得到底下訂單資料
	| OrderID | CustomerID | EmployeeID | OrderDate               | RequiredDate            | ProductID | UnitPrice | Quantity | Discount |
	| 10248   | VINET      | 5          | 1996-07-04 00:00:00.000 | 1996-08-01 00:00:00.000 | 11        | 14.00     | 15       | 0        |
	| 10248   | VINET      | 5          | 1996-07-04 00:00:00.000 | 1996-08-01 00:00:00.000 | 42        | 9.80      | 15       | 0        |
	| 10248   | VINET      | 5          | 1996-07-04 00:00:00.000 | 1996-08-01 00:00:00.000 | 72        | 34.80     | 15       | 0        |
