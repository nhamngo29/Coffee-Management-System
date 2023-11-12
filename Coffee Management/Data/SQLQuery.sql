create database CoffeeManagement
go

use CoffeeManagement
go
--Bảng bàn
create table TableCoffee
(
	ID int identity primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên',
	Status nvarchar(100) not null default N'Trống' 
)
--Bảng thể loại account để phẩn ra người quản lý và nv
create table AccountType
(
	ID int identity primary key,
	TypeName nvarchar(50) not null
)
go
--Bảng account 
create table Account
(
	UserName varchar(100) primary key,
	DisplayName nvarchar(100) not null default N'Name',
	Password varchar(500) not null default 0,
	TypeID int not null
	foreign key (TypeID) references AccountType(ID)
)
go
--thể loại đồ ăn
create table CategoryFood
(
	ID int identity not null primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên'
)
go
--bảng nhóm món ăn loại món ăn
create table TypeFood
(
	Id INT IDENTITY PRIMARY KEY,
	Name nvarchar(100) NOT NULL DEFAULT N'Chưa đặt tên',
	IdCategory INT FOREIGN KEY REFERENCES CategoryFood(Id)
)
--Món ăn món uống
create table Food
(
	ID int identity primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên',--tên
	Type INT NOT NULL,--nhóm món ăn
	Price int not null default 0  --giá
	CONSTRAINT FK_Food_Type FOREIGN KEY(Type) REFERENCES TypeFood(Id) 
)
go

create table Bill
(
	ID int identity primary key,
	CheckIn Date not null default GETDATE(),--ngày checkin
	CheckOut Date, -- ngày check out
	TableID int not null, 
	Discount int not null default 0, -- giảm giá
	TotalPrice int default 0, -- tổng tiền
	Status int not null default 0 -- 1: Da thanh toan, 0: Chua thanh toan
	foreign key (TableID) references TableCoffee(ID)
)
go
--
create table BillInfo
(
	ID int identity primary key,
	BillID int not null,
	FoodID int not null,
	Amount int not null default 0
	foreign key (BillID) references Bill(ID),
	foreign key (FoodID) references Food(ID)
)
go
create table discount
(
	ID varchar(10) primary key,
	NumPercent int,
	Quantity int
)
--Insert discount
declare @Id varchar(6)=(SELECT LEFT(REPLACE(NEWID(),'-',''),6) AS Random10)
DECLARE @i INT=0
WHILE @i<= 10
BEGIN
	INSERT INTO Discount
	VALUES ((SELECT LEFT(REPLACE(NEWID(),'-',''),6) AS Random10),30,5)
	set @i=@i+1;
END
select * from discount
insert AccountType (TypeName) values (N'Quản lý')
insert AccountType (TypeName) values (N'Nhân viên')
select * from Account
insert into Account (UserName, DisplayName, Password, TypeID)
values
('admin', 'Quản lý', '21232F297A57A5A743894A0E4A801FC3', 1)--admin
go
-- Thêm bàn
declare @i int = 1
while @i <= 30
begin
	insert into TableCoffee(Name)
	values (N'Bàn ' + CAST(@i as nvarchar(100)))
	set @i = @i + 1
end
go

-- add category
insert into CategoryFood 
values
(N'Đồ ăn'),
(N'Đồ uống'),
(N'Khác')
select * from CategoryFood
---------------------------
-- Thêm typefood
Insert into TypeFood
values
(N'Cà phê',2),
(N'Freeze',2),
(N'Trà',2),
(N'Bánh',1),
(N'Khác',3)
select * from TypeFood
---------------------------
--Thêm food
INSERT INTO Food
VALUES
(N'PHIN Sữa Đá',1,35000),
(N'Phin Đen Đá',1,35000),
(N'Bạc Xỉu Đá',1,35000),
(N'Cà Phê Espresso',1,35000),
(N'Freeze Trà Xanh',2,59000),
(N'Freeze Sô-cô-la',2,59000),
(N'Trà Sen Vàng',3,49000),
(N'Trà Thạch Đào',3,49000),
(N'Trà Thanh Đào',3,49000),
(N'Trà Thạch Vải',3,49000),
(N'Trà Đào Cam Sả',3,49000),
(N'Bánh Ngọt',4,25000),
(N'Bánh Mì Pate',4,25000),
(N'Bánh Mì Ốp La',4,35000),
(N'Cà Phê Đóng Gói',5,100000),
(N'Merchandise',5,100000)
select * from food
---------------------------
-- Account's procedure
CREATE PROC SP_Login
@UserName NVARCHAR(100), @Password NVARCHAR(100)
AS
	SELECT *
	FROM dbo.Account
	WHERE UserName = @UserName AND Password = @Password
GO
select * from Account where UserName ='admin'

CREATE PROC SP_GetAccountByUserName
@UserName VARCHAR(100)
AS
	SELECT *
	FROM dbo.Account
	WHERE UserName = @UserName
GO

CREATE PROC SP_GetAllAccount
AS
	SELECT UserName, DisplayName, TypeID FROM dbo.Account
GO

CREATE PROC SP_InsertAccount
@UserName VARCHAR(100), @DisplayName NVARCHAR(100), @TypeID INT
AS
	INSERT dbo.Account ( UserName, DisplayName, TypeID )
	VALUES  ( @UserName, @DisplayName, @TypeID )
GO

CREATE PROC SP_ResetPassword
@UserName VARCHAR(100)
AS
	UPDATE dbo.Account SET Password = 'C4CA4238A0B923820DCC509A6F75849B' WHERE UserName = @UserName--Mật khẩu mặt định là 1
GO
select * from Account
CREATE PROC SP_UpdateAccount
@UserName VARCHAR(100), @DisplayName NVARCHAR(100), @Password VARCHAR(100), @NewPassword VARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM Account WHERE UserName = @UserName and Password = @Password
	IF (@isRightPass = 1)
	BEGIN
		IF (@NewPassword = null or @NewPassword = '')
			UPDATE Account SET DisplayName = @DisplayName WHERE UserName = @UserName
		ELSE
			UPDATE Account SET DisplayName = @DisplayName, Password = @NewPassword WHERE UserName = @UserName
	END
END
GO
------
CREATE PROC SP_UpdateAccountFromAdmin @UserName VARCHAR(100), @DisplayName NVARCHAR(100),@TypeAccount int
AS
BEGIN
	DECLARE @isRight INT =0
	SELECT @isRight =COUNT(*) from Account where UserName=@UserName
		IF(@isRight=1)
			BEGIN
				UPDATE Account SET DisplayName=@DisplayName,TypeID=@TypeAccount WHERE UserName=@UserName
			END
END
CREATE PROC SP_DeleteAccount
@UserName VARCHAR(100)
AS
	DELETE dbo.Account WHERE UserName = @UserName
GO

CREATE PROC USP_SearchAccountByUserName
@UserName VARCHAR(100)
AS
	SELECT * FROM dbo.Account WHERE dbo.fuConvertToUnsign1(UserName) LIKE N'%' + dbo.fuConvertToUnsign1(@UserName) + '%'
GO
-- end Account's procedure

-- Food's procedure
CREATE PROC SP_GetAllFood
AS
	SELECT * FROM dbo.Food
GO
execute SP_GetAllFood

CREATE PROC SP_GetTypeFoodByIdCategory @ID INT
AS
BEGIN
	SELECT * FROM TypeFood WHERE IdCategory=@ID
END  

CREATE PROC SP_GetListFoodByTypeFoodID
@TypeFoodID INT
AS
	SELECT ID, Name, Price FROM dbo.Food WHERE Type = @TypeFoodID
GO
execute SP_GetListFoodByTypeFoodID 3
CREATE PROC SP_InsertFood @Name NVARCHAR(100), @TypeID INT, @Price INT
AS
	INSERT dbo.Food( Name, Type, Price )
	VALUES  ( @Name, @TypeID, @Price )
GO

CREATE PROC SP_UpdateFood
@ID INT, @Name NVARCHAR(100), @TypeID INT, @Price INT
AS
	DECLARE @BillIDCount INT = 0
	SELECT @BillIDCount = COUNT(*) FROM Bill AS b, BillInfo AS bi WHERE FoodID = @ID AND b.ID = bi.BillID AND b.Status = 0

	IF (@BillIDCount = 0)
		UPDATE dbo.Food SET Name = @Name, Type = @TypeID, Price = @Price WHERE ID = @ID
GO

CREATE PROC SP_DeleteFood
@FoodID INT
AS
BEGIN
	DECLARE @BillIDCount INT = 0
	SELECT @BillIDCount = COUNT(*) FROM Bill AS b, BillInfo AS bi WHERE FoodID = @FoodID AND b.ID = bi.BillID AND b.Status = 0

	IF (@BillIDCount = 0)
	BEGIN
		DELETE BillInfo WHERE FoodID = @FoodID
		DELETE Food WHERE ID = @FoodID
	END
END
GO

CREATE PROC SP_DeleteTypeFood @TypeFoodId INT
AS
BEGIN
	DECLARE @BillIDCount INT = 0,@FoodID int
	SELECT @BillIDCount = COUNT(*),@FoodID=F.ID FROM Bill, Food AS F, TypeFood AS TF ,BillInfo as BI where F.Type=TF.Id and BI.FoodID =F.ID and TF.Id=@TypeFoodId and Bill.ID=BI.BillID and Status=0 group by F.ID
	IF (@BillIDCount = 0)
	BEGIN
		DELETE BillInfo WHERE FoodID = @FoodID
		DELETE Food WHERE ID = @FoodID
		Delete TypeFood where Id=@TypeFoodId
	END
END
GO

------------------------------
--proc get tên id thể loại typefood
CREATE PROC SP_GetTypeListIdNameNameCategory
AS
BEGIN
	select TypeFood.Id as [Mã loại],IdCategory,TypeFood.Name as [Tên loại],CategoryFood.Name as[Tên thể loại] from TypeFood,CategoryFood where TypeFood.IdCategory=CategoryFood.ID
END

CREATE PROC SP_SearchFoodByName
@Name NVARCHAR(100)
AS
	SELECT * FROM dbo.Food WHERE dbo.fuConvertToUnsign1(Name) LIKE N'%' + dbo.fuConvertToUnsign1(@Name) + '%'
GO
-- end Food's procedure

-- Bill's procedure
CREATE PROC SP_InsertBill
@TableID INT
AS
	INSERT dbo.Bill (CheckIn, TableID, status, discount) VALUES (GETDATE(), @TableID, 0, 0)
GO

CREATE PROC GetUnCheckBillIDByTableID
@TableID INT
AS
	SELECT * FROM dbo.Bill WHERE TableID = @TableID AND Status = 0
GO

CREATE PROC SP_GetListBillByDay
@FromDate DATE, @ToDate DATE
AS
BEGIN
	SELECT b.ID, t.Name, CheckIn, discount, TotalPrice
	FROM Bill AS b, TableCoffee AS t
	WHERE CheckIn >= @FromDate AND CheckIn <= @ToDate AND b.status = 1 AND t.ID = b.TableID
END
GO

CREATE PROC SP_DeleteBill
@ID INT
AS
	DELETE dbo.Bill WHERE ID = @ID
GO

CREATE PROC SP_CheckOut
@ID INT, @Discount INT, @TotalPrice INT
AS
	UPDATE dbo.Bill SET Status = 1, Discount = @Discount, TotalPrice = @TotalPrice,CheckOut=GETDATE() WHERE ID = @ID
GO

CREATE PROC SP_GetMaxBillID
AS
	SELECT MAX(ID) FROM dbo.Bill
GO
-- end Bill's procedure

-- Bill Info's procedure
CREATE PROC SP_InsertBillInfo
@BillID int, @FoodID int, @Amount int
as
begin
	declare @isExistBillInfo int
	declare @foodAmount int = 1

	select @isExistBillInfo = ID, @foodAmount = Amount
	from BillInfo
	where BillID = @BillID and FoodID = @FoodID

	if (@isExistBillInfo > 0)
	begin
		declare @newAmount int = @foodAmount + @Amount
		if (@newAmount > 0)
			update BillInfo set Amount = @newAmount where FoodID = @FoodID
		ELSE IF (@newAmount <= 0)
			delete BillInfo where BillID = @BillID and FoodID = @FoodID
	end
	else
		IF (@Amount > 0)
			INSERT into BillInfo (BillID, FoodID, Amount) values (@BillID, @FoodID, @Amount)
end
GO

CREATE PROC SP_DeleteBillInfoByBillID
@BillID INT
AS
	DELETE dbo.BillInfo WHERE BillID = @BillID
GO
-- end Bill's procedure
create trigger UTG_UpdateBillInfo
on BillInfo for insert
as
begin
	declare @billID int
	select @billID = BillID from inserted

	declare @tableID int
	select @tableID = TableID from Bill where ID = @billID and status = 0

	declare @count int
	select @count = COUNT(*) from BillInfo where BillID = @billID

	if (@count > 0)
		update TableCoffee set Status = N'Có người' where ID = @tableID
	else
		update TableCoffee set Status = N'Trống' where ID = @tableID
end
go

CREATE TRIGGER TG_UpdateBill
on Bill for update
as
begin
	declare @billID int
	select @billID = ID from inserted
	declare @tableID int
	select @tableID = TableID from Bill where ID = @billID
	declare @amount int = 0
	select @amount = COUNT(*) from Bill where TableID = @tableID and Status = 0
	if (@amount = 0)
		update TableCoffee set Status = N'Trống' where ID = @tableID
end
GO

create trigger TG_DeleteBillInfo
on BillInfo for delete
as
begin
	declare @IDBillInfo int
	declare @BillID int
	select @IDBillInfo = id, @BillID = BillID from deleted

	declare @TableID int
	select @TableID = TableID from Bill where ID = @BillID

	declare @count int = 0
	select @count = COUNT(*) from BillInfo as bi, Bill as b where b.ID = bi.BillID and b.ID = @BillID and b.status = 0

	if (@count = 0)
		update TableCoffee set Status = N'Trống' where ID = @TableID
end
go

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000)
AS
BEGIN
	IF @strInput IS NULL RETURN @strInput
	IF @strInput = '' RETURN @strInput

	DECLARE @RT NVARCHAR(4000)
	DECLARE @SIGN_CHARS NCHAR(136)
	DECLARE @UNSIGN_CHARS NCHAR (136)

	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272)+ NCHAR(208)
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
	
	DECLARE @COUNTER int
	DECLARE @COUNTER1 int
	SET @COUNTER = 1

	WHILE (@COUNTER <= LEN(@strInput))
	BEGIN
		SET @COUNTER1 = 1
		WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
			BEGIN
				IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
				BEGIN
					IF @COUNTER=1
						SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)
					ELSE
						SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)
					BREAK
				END
					SET @COUNTER1 = @COUNTER1 +1
			END
			SET @COUNTER = @COUNTER +1
	END
	SET @strInput = replace(@strInput,' ','-')
	RETURN @strInput
END
GO

create proc SP_GetListBillByDayForReport
@FromDate Date, @ToDate Date
as
begin
	select t.Name, CheckIn, Discount, TotalPrice
	from Bill as b, TableCoffee as t
	where CheckIn >= @FromDate and CheckIn <= @ToDate and b.status = 1 and t.ID = b.TableID
end
go

create proc SP_DeleteCategory
@ID int
as
begin
	declare @FoodCount int = 0
	select @FoodCount = COUNT(*) from Food where Type = @ID

	if (@FoodCount = 0)
		delete CategoryFood where ID = @ID
end
go

-- TableFood's procedure
create proc SP_DeleteTableFood
@ID int
as begin
	declare @count int = 0
	select @count = COUNT(*) from TableCoffee where ID = @ID and Status = N'Trống'

	if (@count <> 0)
	begin	declare @BillID int
		select @BillID = b.ID from Bill as b, TableCoffee as t where b.TableID = t.ID

		delete BillInfo where BillID = @BillID
		delete Bill where ID = @BillID
		delete TableCoffee where ID = @ID
	end
end
GO
--23   24
CREATE PROC SP_SwitchTable
@TableID1 INT, @TableID2 INT
AS
BEGIN
	DECLARE @isTable1Null INT = 0
	DECLARE @isTable2Null INT = 0
	SELECT @isTable1Null = ID FROM dbo.Bill WHERE TableID = @TableID1 AND Status = 0
	SELECT @isTable2Null = ID FROM dbo.Bill WHERE TableID = @TableID2 AND Status = 0

	IF (@isTable1Null = 0 AND @isTable2Null > 0)
		BEGIN
			UPDATE dbo.Bill SET TableID = @TableID1 WHERE ID = @isTable2Null
			UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID1
			UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID2
        END
	ELSE IF (@isTable1Null > 0 AND @isTable2Null = 0)
		BEGIN
			UPDATE dbo.Bill SET TableID = @TableID2 WHERE Status = 0 AND ID = @isTable1Null
			UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID2
			UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID1
        END
    ELSE IF (@isTable1Null > 0 AND @isTable2Null > 0)
		BEGIN
			UPDATE dbo.Bill SET TableID = @TableID2 WHERE ID = @isTable1Null
			UPDATE dbo.Bill SET TableID = @TableID1 WHERE ID = @isTable2Null
        END
END
GO
select * from Bill
--------------------------------
--Proc xóa món
CREATE PROC SP_DeleteFoodByIdBill @BillID INT,@FoodName nvarchar(100),@Count INT 
AS
BEGIN
	declare @isExistBillInfo int,@foodAmount int = 1,@FoodId int
	select @isExistBillInfo = BillInfo.ID, @foodAmount = Amount,@FoodId=BillInfo.FoodID
	from BillInfo,Food
	where BillID = @BillID and FoodID = Food.ID and Food.Name=@FoodName 
	if (@isExistBillInfo > 0)
	begin
		declare @newAmount int = @foodAmount - @Count
		if (@newAmount > 0)
				update BillInfo set Amount = @newAmount where FoodID = @FoodID and BillID=@BillID
		ELSE IF (@newAmount <= 0)
			delete BillInfo where BillID = @BillID and FoodID = @FoodID
	end
END
--------------------------------
select * from Bill,BillInfo 
where Bill.ID=BillInfo.BillID and TableID=21 AND Status = 0
select * from Bill,BillInfo 
where Bill.ID=BillInfo.BillID and TableID=22 AND Status = 0
--Proc gộp bàn
--@TableID1 bạn bị gộp  @TableID2 bàn gộp

---@isTable1Null bill của bàn bị gộp
--@isTable2Null bill bạn gộp

CREATE PROC SP_BillardTable @TableID1 INT, @TableID2 INT
AS
BEGIN
	DECLARE @isTable1Null INT = 0
	DECLARE @isTable2Null INT = 0
	SELECT @isTable1Null = ID FROM dbo.Bill WHERE TableID = @TableID1 AND Status = 0
	SELECT @isTable2Null = ID FROM dbo.Bill WHERE TableID = @TableID2 AND Status = 0
	print(@isTable1Null)
	print(@isTable2Null)
	IF (@isTable1Null = 0 AND @isTable2Null > 0)
		BEGIN
			UPDATE dbo.Bill SET TableID = @TableID1 WHERE ID = @isTable2Null
			UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID1
			UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID2
        END
	ELSE IF (@isTable1Null > 0 AND @isTable2Null = 0)
		BEGIN
			print(N'Vô trong bản có trống từ bàn có người')
			UPDATE dbo.Bill SET TableID = @TableID2 WHERE Status = 0 AND ID = @isTable1Null
			UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID2
			UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID1
        END
    ELSE IF (@isTable1Null > 0 AND @isTable2Null > 0)
		BEGIN
			SELECT ID INTO IDBillInfoTable FROM BillInfo WHERE BillID=@isTable1Null
			--select * from IDBillInfoTable
			UPDATE BillInfo SET BillID=@isTable2Null WHERE ID IN(SELECT * FROM IDBillInfoTable)

			UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID1
			DROP table IDBillInfoTable
        END
END

SELECT id FROM BillInfo WHERE BillID=9

select * from Bill,BillInfo 
where Bill.ID=BillInfo.BillID and TableID=23 AND Status = 0
select * from Bill,BillInfo 
where Bill.ID=BillInfo.BillID and TableID=22 AND Status = 0

execute SP_BillardTable 23,22

CREATE PROC SP_GetAllTable
AS
	SELECT ID, Name FROM dbo.TableCoffee
GO

CREATE PROC SP_GetListTable
AS
	SELECT * FROM dbo.TableCoffee
GO

CREATE PROC SP_InsertTable
@Name NVARCHAR(100)
AS
	INSERT dbo.TableCoffee ( Name )
	VALUES  ( @Name )
GO

CREATE PROC SP_UpdateTable
@ID INT, @Name NVARCHAR(100)
AS
	UPDATE dbo.TableCoffee SET Name = @Name WHERE ID = @ID
GO
-- end TableCoffee's procedure

CREATE PROC SP_GetListTempBillByTableID
@TableID INT
AS
	SELECT f.Name, bi.Amount, f.Price, f.Price * bi.Amount AS totalPrice
	FROM dbo.BillInfo bi, dbo.Bill b, dbo.Food f
	WHERE b.ID = bi.BillID AND bi.FoodID = f.ID AND b.Status = 0 AND b.TableID = @TableID
GO


---------------------------------
--insert typeFood
CREATE PROC SP_InsertTypeFood @Name NVARCHAR(100),@IdCategory INT
AS
BEGIN
	INSERT INTO TypeFood VALUES (@NAME,@IdCategory)
END
CREATE PROC SP_UpdateTypeFood @Id int, @Name NVARCHAR(100),@IdCategory INT
AS
BEGIN
	UPDATE TypeFood
	SET Name=@Name,IdCategory=@IdCategory
	WHERE Id=@Id
END
insert into TypeFood
values
('Xoa',3)

-------
--paning
select * from Bill
SP_GetListBillByDateAndPage '20221201','20221231',1
alter PROC SP_GetListBillByDateAndPage @FromDate date,@ToDate date,@Page int
AS
BEGIN
	DECLARE @pageRow INT = 10
	DECLARE @selectRows INT = @pageRow*@Page
	DECLARE @exceptRows INT =(@page -1) * @pageRow
	select TOP(@selectRows) b.ID, t.Name, CheckIn, Discount, TotalPrice
	from Bill as b, TableCoffee as t
	where CheckIn >= @FromDate and CheckIn <= @ToDate and b.status = 1 and t.ID = b.TableID
	EXCEPT
	select TOP(@exceptRows)b.ID, t.Name, CheckIn, Discount, TotalPrice
	from Bill as b, TableCoffee as t
	where CheckIn >= @FromDate and CheckIn <= @ToDate and b.status = 1 and t.ID = b.TableID

END
--------------------------
-----
SELECT *  FROM BILL
CREATE PROC GetNumBillByDate @FromDate date,@ToDate date
AS
BEGIN
SELECT COUNT(*) FROM BILL AS B 
	WHERE CheckIn >=@FromDate AND CheckOut<=@ToDate and B.Status=1
END
SELECT * FROM Bill
PRINT([dbo].FN_GetNumBillByDate('20221201','20221230'))
SELECT COUNT(*) FROM BILL AS B 
	WHERE CheckIn >='20221201' AND CheckOut<='20221230' and B.Status=1
	SELECT * FROM Bill
SP_GetListBillByDateAndPage
GetNumBillByDate '20221201','20221231',1
-----------------------------------------------------------
alter PROC SP_GetNumPercent @ID varchar(10)
AS
BEGIN
	DECLARE @NumPercent INT = 0
	SET @NumPercent=(SELECT TOP 1 NumPercent from discount where ID=@ID and Quantity>0)
	IF(@NumPercent>0)
	BEGIN
		UPDATE Discount SET Quantity =Quantity-1
		where ID=@ID
	END
	SELECT @NumPercent
END
select * from discount
SP_GetNumPercent '0FCD56'


alter PROC SP_InsertDiscount @NumPercent int,@Quantity INT
AS
BEGIN
	declare @Idd varchar(6)=(SELECT LEFT(REPLACE(NEWID(),'-',''),6) AS Random10)
	INSERT INTO Discount
	VALUES ((SELECT LEFT(REPLACE(NEWID(),'-',''),6) AS Random10),@NumPercent,@Quantity)
END

create proc SP_DeleteDisscount @ID varchar(6)
as
begin
	delete  discount where ID=@ID
end
select * from discount