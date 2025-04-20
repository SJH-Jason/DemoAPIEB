namespace DemoAPIEB
{
    public class InsertDTO
    {
        public int 出表日期 { get; set; }
        public int 資料年月 { get; set; }
        public int 公司代號 { get; set; }
        public string 公司名稱 { get; set; } = string.Empty;
        public string 產業別 { get; set; } = string.Empty;
        public int 營業收入_當月營收 { get; set; }
        public int 營業收入_上月營收 { get; set; }
        public int 營業收入_去年當月營收 { get; set; }
        public float 營業收入_上月比較增減 { get; set; }
        public int 營業收入_去年同月增減 { get; set; }
        public int 累計營業收入_當月累計營收 { get; set; }
        public int 累計營業收入_去年累計營收 { get; set; }
        public float 累計營業收入_前期比較增減 { get; set; }
        public string 備註 { get; set; } = string.Empty;
    }
}
