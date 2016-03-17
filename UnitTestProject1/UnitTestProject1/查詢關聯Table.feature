#因為被別的表關聯，所以已有事先建部份[Shippers]資料在DB
#	| ShipperID | CompanyName      | Phone          |
#	| 1         | Speedy Express   | (503) 555-9831 |
#	| 2         | United Package   | (503) 555-3199 |
#	| 3         | Federal Shipping | (503) 555-9931 |

#若照其他查詢情境的作法，在Background提供資料

#步驟：
#1. 在 Background 先新增[Shippers]資料(ShipperID 4,5,6)，確保有資料可以查
#2. When 調用GetShippers測試

#問題：
#　若照這寫法，Background跟Expected會有落差，而且之後加了其他資料，測試就會失敗了

#想到的解決方式
#1. 先Delete [Shippers]，但這還要先清除其他關聯table資料，測試完後再將(ShipperID 1,2,3)加回去
#2. 在GetShippers加入注入的點，


Feature: 查詢Shippers

Background: 
	Given 資料庫Shippers資料
	| ShipperID | CompanyName    | Phone          |
	| 4         | United Express | (503) 555-9831 |
	| 5         | BBB Package    | (503) 555-3199 |
	| 6         | CCC Shipping   | (503) 555-9931 |


Scenario: 我查詢Shippers資料
	Given 查詢CompayName包含
	| CompanyName |
	| Express     |
	When 我調用GetShippers
	Then 我會得到Shippers資料如下
	| ShipperID | CompanyName    | Phone          |
	| 1         | Speedy Express | (503) 555-9831 |
	| 4         | United Express | (503) 555-9831 |