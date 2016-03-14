#這個作業主要是要測試新增[Order], [Order Details]，但關聯的Table還有[Employees], [Customers], [Shippers]

#步驟：
#1. 為了減少初始化資料，將[Employees], [Customers], [Shippers]測試資料事先建在測試DB
#2. BeforeScenario先刪除[Order Details]及[Order] ID=10248 的資料，確保沒有重複的P Key
#3. When 調用Insert測試
#4. AfterScenario再刪除一次[Order Details]及[Order] ID=10248 的資料，還原資料


Feature: 新增訂單

Scenario: 我在訂單作業新增訂單資料
	Given Orders資料
	| OrderID | CustomerID | EmployeeID | OrderDate               | RequiredDate            | ShippedDate             | ShipVia | Freight | ShipName                  | ShipAddress        | ShipCity | ShipRegion | ShipPostalCode | ShipCountry |
	| 10248   | VINET      | 5          | 1996-07-04 00:00:00.000 | 1996-08-01 00:00:00.000 | 1996-07-16 00:00:00.000 | 3       | 32.38   | Vins et alcools Chevalier | 59 rue de l'Abbaye | Reims    | NULL       | 51100          | France      |
	And Order Details資料
	| OrderID | ProductID | UnitPrice | Quantity | Discount |
	| 10248   | 11        | 14.00     | 12       | 0        |
	| 10248   | 72        | 34.80     | 5        | 0        |
	| 10248   | 42        | 9.80      | 10       | 0        |
	When 我調用Insert
	Then 我會得到底下訂單資料
	| OrderID | CustomerID | EmployeeID | OrderDate               | RequiredDate            | ProductID | UnitPrice | Quantity | Discount |
	| 10248   | VINET      | 5          | 1996-07-04 00:00:00.000 | 1996-08-01 00:00:00.000 | 11        | 14.00     | 12       | 0        |
	| 10248   | VINET      | 5          | 1996-07-04 00:00:00.000 | 1996-08-01 00:00:00.000 | 42        | 9.80      | 10       | 0        |
	| 10248   | VINET      | 5          | 1996-07-04 00:00:00.000 | 1996-08-01 00:00:00.000 | 72        | 34.80     | 5        | 0        |
