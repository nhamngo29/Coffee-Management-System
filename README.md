# Quản lý quán cà phê WinForm CSharp C#
<p>Language: C#, .Net Core 6</p>
<p>Database: SQLSaver </p>
<p>Thư viện hộ trợ: DevExpress</p>
<p>Các ứng dụng hộ trợ: Telegram, Email</p>
**Môn học: Phát triển phần mềm ứng dụng thông minh**

<hr/>
<p>Giảng viên hướng dẫn:</p>
<ul>
  <li>Bùi Công Danh</li>
</ul>
<p>Member:</p>
<ul>
   <li>Nguyễn Nhâm Ngọ - 2001207130 Git(https://github.com/nhamngo29)</li>
   <li>Phan Thị Mỹ Quyên - 2001207102 Git(https://github.com/myquyen1004)</li>
  <li>Đồng Minh Phương - 2001207143 Git(https://github.com/mphuongne14)</li>
</ul>
<div align="center">

# PHÂN CÔNG CÔNG VIỆC

</div>

| STT | Họ tên  | Nôi dung công việc | Ghi chú |
|--------------|-------|------|-------|
| 1 | Nguyễn Nhâm Ngọ | - Thiết kệ CSDL, nhập liêu, proc,trigger nhập liệu bảng </br> - Form quản lý thực đơn, Form nhập xuất kho, Form hóa đơn, Form nhân viên, Form bàn ăn, Form tài khoản frm main, Form đặt bàn, Web đặt bàn cho client, Form order xử lý nghiệp vụ tất cả các form | Hoàn thành 100%  |
| 2 | Phan Thị Mỹ Quyên | - Form quản lý hóa đơn, thông kê, vẽ sơ đồ, viết trigger nghiệp của form | Hoàn thành 100% |
| 3  | Đồng Minh Phương | - Thiết kế CSDL, Nhập liệu, Form phân quyền| Hoàn thành 100% |

__I. Form__
  
  1. Form login
  
   <div align="center">
  
  ![image](https://github.com/nhamngo29/Coffee-Management/assets/107678223/5554818e-5e39-425e-9e34-d4b1257a6a58)

  </div>

<div align="center">

    **Nhân Viên**
  
</div>
  2. Form chính
  
  ![image](https://github.com/nhamngo29/Coffee-Management/assets/107678223/18a9a66e-da76-406d-a2a4-15f464f91140)
  
  3. Form đặt bàn
    
 ![image](https://github.com/nhamngo29/Coffee-Management/assets/107678223/c0768b5f-92a6-4f55-9099-91456216dd2b)

  4. Form profile
  
  ![image](https://github.com/nhamngo29/Coffee-Management/assets/107678223/c9663637-ccbe-4698-b171-f11850dc1cb0)
  
  5. Reporting hóa đơn
  
  ![image](https://github.com/nhamngo29/Coffee-Management/assets/107678223/80edd20e-fd94-4bea-9687-2cedbad231a7)

  6. Thông tin hóa đơn gửi qua tele
  
  ![image](https://github.com/nhamngo29/Coffee-Management/assets/107678223/16a9d053-86f7-4966-bf39-8be7b978fad6)

  7. Form await
 <div align="center">
   
  ![image](https://github.com/nhamngo29/Coffee-Management/assets/107678223/1ec43f14-6e79-4075-9bdf-d78c4420c993)

</div>
  
<div align="center">

    **Quản trị viên**
  
</div>

  6. Form quản lý món ăn/uống
  ![image](https://user-images.githubusercontent.com/107678223/210323292-11c451cc-f7b7-4174-b272-08a979469a4e.png)
  7. Form quản lý loại thức ăn/uống
  ![image](https://user-images.githubusercontent.com/107678223/210323390-6b2f1522-8bd3-4cf3-9d8d-17a2a25b2678.png)
  8. Form quản lý thể loại thức ăn/uống
  ![image](https://user-images.githubusercontent.com/107678223/210323451-84cadc28-842e-42cd-975e-1173826b3d88.png)
  9. Form quản lý bàn
  ![image](https://user-images.githubusercontent.com/107678223/210323498-7d81271d-3c89-45c0-b77e-0cb6dfa9bb7e.png)
  10. Form quản lý user đăng nhập
  ![image](https://user-images.githubusercontent.com/107678223/210323565-17301276-1171-41ed-a367-21f619c49d89.png)
  11. Form quản lý mã giảm giá
  ![image](https://user-images.githubusercontent.com/107678223/210323622-bbcbb1a0-357e-4d47-a58a-7e25f9d5322a.png)
  12. Form quản lý doanh thu theo ngày tháng
  ![image](https://user-images.githubusercontent.com/107678223/210323721-86ccb034-fddb-4656-8429-a1b548635c81.png)
  
  
  
  __II. Phần mềm cài đặt__
  -	PM Visual Studio 2019.
  -	PM DevExpress Components for .Net 22.2.2
  -	PM SQL Server 2019.
  
  __III. Hướng dẫn mở Source__  
    1. Kết nối:
    
      - Để cấu hình kết nối, các bạn vào tầng project  "DAO"  → Tìm class "DataProvider.cs"  sau đó tìm dòng: private string connectionString = @" Data Source=.\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True"; 
      
      → Thay đổi chuỗi kết nối đến Sqlserver cho phù hợp với máy tính của bạn hoặc có thể sử dụng chuổi kết nối Database online của mình đã deploy trên internet:private string connectionString=@"DataSource=SQL5109.site4now.net,1433;InitialCatalog= db_a91e51_nhamngoo;UserId=db_a91e51_nhamngoo_admin;Password=02092002Aa;"
