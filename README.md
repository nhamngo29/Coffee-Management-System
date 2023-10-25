# Quản lý quán cà phê Winfrom CSharp C#
<p>Language: C#</p>
<p>Database: SQLSaver </p>
<p>Thư viện hộ trợ: DevExpress</p>
**Môn học: Phát triển phần mềm ứng dụng thông minh**

<hr/>
<p>Giảng viên hướng dẫn:</p>
<ul>
  <li>Bùi Công Danh</li>
</ul>
<p>Member:</p>
<ul>
  <li>Nguyễn Nhâm Ngọ - 2001207130</li>
  <li>Phan Thị Mỹ Quyên - 2001207102</li>
  <li>Đồng Minh Phương - 2001207143</li>
</ul>
__I. From__
  
  1. From login
  
   <div align="center">
  
  ![image](https://user-images.githubusercontent.com/107678223/209601895-42e9d5f1-6c83-4f52-a639-9c860911a488.png)
  
  </div>

<div align="center">

    **Nhân Viên**
  
</div>
  
  
  2. From chính
  ![image](https://user-images.githubusercontent.com/107678223/209601988-674092c9-1549-4c9c-85e9-a913b6143982.png)
  3. From tác vụ
  ![image](https://user-images.githubusercontent.com/107678223/210324354-e9132fdd-789d-4b3d-94c3-6bd2d1a68d6c.png)
  4. From profile
  ![image](https://user-images.githubusercontent.com/107678223/209602090-9c60f173-4883-439c-aae2-741dff65597d.png)
  5. Reporting hóa đơn
  ![image](https://user-images.githubusercontent.com/107678223/209602245-01bff54a-540f-474c-a774-085e6f89b640.png)
  
<div align="center">

    **Quản trị viên**
  
</div>

  6. From quản lý món ăn/uống
  ![image](https://user-images.githubusercontent.com/107678223/210323292-11c451cc-f7b7-4174-b272-08a979469a4e.png)
  7. From quản lý loại thức ăn/uống
  ![image](https://user-images.githubusercontent.com/107678223/210323390-6b2f1522-8bd3-4cf3-9d8d-17a2a25b2678.png)
  8. From quản lý thể loại thức ăn/uống
  ![image](https://user-images.githubusercontent.com/107678223/210323451-84cadc28-842e-42cd-975e-1173826b3d88.png)
  9. From quản lý bàn
  ![image](https://user-images.githubusercontent.com/107678223/210323498-7d81271d-3c89-45c0-b77e-0cb6dfa9bb7e.png)
  10. From quản lý user đăng nhập
  ![image](https://user-images.githubusercontent.com/107678223/210323565-17301276-1171-41ed-a367-21f619c49d89.png)
  11. From quản lý mã giảm giá
  ![image](https://user-images.githubusercontent.com/107678223/210323622-bbcbb1a0-357e-4d47-a58a-7e25f9d5322a.png)
  12. From quản lý doanh thu theo ngày tháng
  ![image](https://user-images.githubusercontent.com/107678223/210323721-86ccb034-fddb-4656-8429-a1b548635c81.png)
  
  
  
  __II. Phần mềm cài đặt__
  -	PM Visual Studio 2019.
  -	PM DevExpress Components for .Net 21.6.2
  -	PM SQL Server 2019.
  -	PM Crystal Report  
 
  __III. Hướng dẫn mở Source__  
    1. Kết nối:
    
      - Để cấu hình kết nối, các bạn vào tầng project  "DAO"  → Tìm class "DataProvider.cs"  sau đó tìm dòng: private string connectionString = @" Data Source=.\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True"; 
      
      → Thay đổi chuỗi kết nối đến Sqlserver cho phù hợp với máy tính của bạn hoặc có thể sử dụng chuổi kết nối Database online của mình đã deploy trên internet:private string connectionString=@"DataSource=SQL5109.site4now.net,1433;InitialCatalog= db_a91e51_nhamngoo;UserId=db_a91e51_nhamngoo_admin;Password=02092002Aa;"
