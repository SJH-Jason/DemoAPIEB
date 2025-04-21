# DemoAPIEB
【系統名稱】

上市公司每月營業收入查詢系統

【功能說明】

✔ 顯示所有上市公司每月營業資料

✔ 可輸入公司代號進行查詢

✔ 可依產業別進行分類篩選

✔ 查詢結果支援分頁（每頁 100 筆）

✔ 自動顯示查詢結果筆數

✔ 前端使用 Vue 3 + Vite設計，後端為 ASP.NET Core Web API

✔ 後端資料連接 SQL Server + 預存程序

【專案結構】

📁 DemoWEBEB   ← 打包後的前端畫面（dist/index.html + assets）

📁 DemoAPIEB   ← ASP.NET Core 專案（包含 Controller + Models + Swagger）

📁 EBSQLData   ← 建表語法 + 預存程序 + 範例資料（.sql 或 .bak）

【執行方式】

1️⃣ 資料庫設定
   - 匯入 EBSQLData 資料表與預存程序

2️⃣ 執行 WebAPI 專案
   - 使用 Visual Studio 開啟 `DemoAPIEB.sln`

3️⃣ 使用 Web 畫面
   - 使用 Visual Studio 開啟 `DemoWEBEB.sln`

【開發工具】
- Visual Studio 2022
- Visual Studio Code
- SQL Server 2019
- Vue 3 / Vite


作者：Jason  
版本：v1.0  
