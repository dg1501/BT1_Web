# Bài Tập 1: Phát Triển Ứng Dụng Trên Nền Web #
## Tạo SOLUTION gồm các Project sau: ##
1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

## CHƯƠNG TRÌNH THỰC HIỆN: TYPING SHOOT GAME ( 1 LOẠI GAME LUYỆN GÕ PHÍM DƯỚI DẠNG MÔ PHỎNG TÀU KHÔNG GIAN)
### Cách Làm ###
1. Tạo Project DLL với loại Project là Class Library (.NET Framework).</p>
<img width="644" height="107" alt="image" src="https://github.com/user-attachments/assets/1391cd57-5888-4417-b997-0fbc879c9a93" /></p>
- Sau khi **Next** sẽ có 1 cửa sổ như sau:</p>
- Tại cửa sổ này tiến hành đặt tên Project, solution name, location và phiên bản Framework</p>
<img width="1122" height="584" alt="image" src="https://github.com/user-attachments/assets/f55e7b06-02f7-4953-aa39-bce273aa8404" /></p>
- [x] Lưu ý</p>
+ Phiên bản visua studio 2022 sẽ không có sẵn .NET Framework 2.0 nên ta phải thực hiện công việc cài đặt nó.</p>
Bước 1: Vào Control Panel -> Programs and Features -> <img width="232" height="48" alt="image" src="https://github.com/user-attachments/assets/0e36658e-5990-4f11-bff6-1b05b2b93964" /></p>
Bước 2: Tích chọn mục Internet Information Servies</p>
<img width="277" height="89" alt="image" src="https://github.com/user-attachments/assets/b2be3714-0fde-4652-8a98-34bac3e382a2" /></p>
+ Sau khi cài xong ta tiếp tục tiến hành tạo Project.</p>
+ Sau khi tạo xong DLL sẽ xuất hiện cửa sổ class1.cs</p>
+ Tại đây ta tiến hành thêm code và build nó</p>
<img width="1849" height="628" alt="image" src="https://github.com/user-attachments/assets/4eec6f9f-ce5e-48d2-b244-3dfacdeda33b" /></p>
+ sau khi build sẽ tạo ra 1 file có đuôi.dll -> <img width="1145" height="112" alt="image" src="https://github.com/user-attachments/assets/1f66170b-892b-42e0-8502-f97af3c4a621" /></p>

2. Tạo Project Console.app (Console App (.NET Framework).</p>
- Sau khi tạo console với tên *cosole_game*, thêm code cho progams.cs và tiến hành **add reference**</p>
<img width="1877" height="646" alt="image" src="https://github.com/user-attachments/assets/c96b0bfd-e0bc-4720-913e-eb9e486453d2" /></p>
+ Chuột phải vào console_game ở cột bên phải -> add -> reference -> tìm đến tệp.dll và add nó.</p>
<img width="917" height="949" alt="image" src="https://github.com/user-attachments/assets/1ce533ca-a2cd-42ad-9265-94602818fe16" /></p>
<img width="762" height="546" alt="image" src="https://github.com/user-attachments/assets/b890a7b1-0fd6-4ab2-baef-ba2203c9d896" /></p>
- Sau khi đã thêm code và add -> ta tiến hành build và chạy thử program.</p>
Kết quả.</p>
<img width="1096" height="637" alt="image" src="https://github.com/user-attachments/assets/8b608bf4-ab9c-4839-96fe-ce14763b7a58" />
+ Mô tả: Khi nhập đúng từ có trong chương trình, người chơi sẽ được điểm số , nếu nhập sai sẽ không có điểm.</p>

3. Tạo Project 




