
namespace Blum_Blum_Shub {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textQ = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.textX0 = new System.Windows.Forms.TextBox();
            this.TextResult = new System.Windows.Forms.TextBox();
            this.textN = new System.Windows.Forms.TextBox();
            this.textP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelError = new System.Windows.Forms.Label();
            this.ListP = new System.Windows.Forms.ComboBox();
            this.ListQ = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextResultBin = new System.Windows.Forms.TextBox();
            this.TextGamma1 = new System.Windows.Forms.TextBox();
            this.TextGamma2 = new System.Windows.Forms.TextBox();
            this.TextGamma3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textQ
            // 
            this.textQ.Location = new System.Drawing.Point(49, 70);
            this.textQ.Name = "textQ";
            this.textQ.Size = new System.Drawing.Size(92, 20);
            this.textQ.TabIndex = 1;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(49, 190);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(83, 37);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Вычислить!";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // textX0
            // 
            this.textX0.Location = new System.Drawing.Point(49, 96);
            this.textX0.Name = "textX0";
            this.textX0.Size = new System.Drawing.Size(185, 20);
            this.textX0.TabIndex = 3;
            // 
            // TextResult
            // 
            this.TextResult.Location = new System.Drawing.Point(240, 19);
            this.TextResult.Multiline = true;
            this.TextResult.Name = "TextResult";
            this.TextResult.ReadOnly = true;
            this.TextResult.Size = new System.Drawing.Size(136, 208);
            this.TextResult.TabIndex = 4;
            this.TextResult.Text = resources.GetString("TextResult.Text");
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(49, 122);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(185, 20);
            this.textN.TabIndex = 5;
            // 
            // textP
            // 
            this.textP.Location = new System.Drawing.Point(49, 44);
            this.textP.Name = "textP";
            this.textP.Size = new System.Drawing.Size(92, 20);
            this.textP.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "x0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "n";
            // 
            // LabelError
            // 
            this.LabelError.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.LabelError.Location = new System.Drawing.Point(12, 154);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(222, 33);
            this.LabelError.TabIndex = 11;
            this.LabelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListP
            // 
            this.ListP.FormattingEnabled = true;
            this.ListP.Items.AddRange(new object[] {
            "<-",
            "3",
            "7",
            "11",
            "19",
            "23",
            "31",
            "43",
            "47",
            "59",
            "67",
            "71",
            "79",
            "83",
            "103",
            "107",
            "127",
            "131",
            "139",
            "151",
            "163",
            "167",
            "179",
            "191",
            "199",
            "211",
            "223",
            "227",
            "239",
            "251",
            "263",
            "271",
            "283",
            "307",
            "311",
            "331",
            "347",
            "359",
            "367",
            "379",
            "383",
            "419",
            "431",
            "439",
            "443",
            "463",
            "467",
            "479",
            "487",
            "491",
            "499",
            "503",
            "523",
            "547",
            "563",
            "571",
            "587",
            "599",
            "607",
            "619",
            "631",
            "643",
            "647",
            "659",
            "683",
            "691",
            "719",
            "727",
            "739",
            "743",
            "751",
            "787",
            "811",
            "823",
            "827",
            "839",
            "859",
            "863",
            "883",
            "887",
            "907",
            "911",
            "919",
            "947",
            "967",
            "971",
            "983",
            "991",
            "1019",
            "1031",
            "1039",
            "1051",
            "1063",
            "1087",
            "1091",
            "1103",
            "1123",
            "1151",
            "1163",
            "1171",
            "1187",
            "1223",
            "1231",
            "1259",
            "1279",
            "1283",
            "1291",
            "1303",
            "1307",
            "1319",
            "1327",
            "1367",
            "1399",
            "1423",
            "1427",
            "1439",
            "1447",
            "1451",
            "1459",
            "1471",
            "1483",
            "1487",
            "1499",
            "1511",
            "1523",
            "1531",
            "1543",
            "1559",
            "1567",
            "1571",
            "1579",
            "1583",
            "1607",
            "1619",
            "1627",
            "1663",
            "1667",
            "1699",
            "1723",
            "1747",
            "1759",
            "1783",
            "1787",
            "1811",
            "1823",
            "1831",
            "1847",
            "1867",
            "1871",
            "1879",
            "1907",
            "1931",
            "1951",
            "1979",
            "1987",
            "1999",
            "2003",
            "2011",
            "2027",
            "2039",
            "2063",
            "2083",
            "2087",
            "2099",
            "2111",
            "2131",
            "2143",
            "2179",
            "2203",
            "2207",
            "2239",
            "2243",
            "2251",
            "2267",
            "2287",
            "2311",
            "2339",
            "2347",
            "2351",
            "2371",
            "2383",
            "2399",
            "2411",
            "2423",
            "2447",
            "2459",
            "2467",
            "2503",
            "2531",
            "2539",
            "2543",
            "2551",
            "2579",
            "2591",
            "2647",
            "2659",
            "2663",
            "2671",
            "2683",
            "2687",
            "2699",
            "2707",
            "2711",
            "2719",
            "2731",
            "2767",
            "2791",
            "2803",
            "2819",
            "2843",
            "2851",
            "2879",
            "2887",
            "2903",
            "2927",
            "2939",
            "2963",
            "2971",
            "2999",
            "3011",
            "3019",
            "3023",
            "3067",
            "3079",
            "3083",
            "3119",
            "3163",
            "3167",
            "3187",
            "3191",
            "3203",
            "3251",
            "3259",
            "3271",
            "3299",
            "3307",
            "3319",
            "3323",
            "3331",
            "3343",
            "3347",
            "3359",
            "3371",
            "3391",
            "3407",
            "3463",
            "3467",
            "3491",
            "3499",
            "3511",
            "3527",
            "3539",
            "3547",
            "3559",
            "3571",
            "3583",
            "3607",
            "3623",
            "3631",
            "3643",
            "3659",
            "3671",
            "3691",
            "3719",
            "3727",
            "3739",
            "3767",
            "3779",
            "3803",
            "3823",
            "3847",
            "3851",
            "3863",
            "3907",
            "3911",
            "3919",
            "3923",
            "3931",
            "3943",
            "3947",
            "3967",
            "4003",
            "4007",
            "4019",
            "4027",
            "4051",
            "4079",
            "4091",
            "4099",
            "4111",
            "4127",
            "4139",
            "4159",
            "4211",
            "4219",
            "4231",
            "4243",
            "4259",
            "4271",
            "4283",
            "4327",
            "4339",
            "4363",
            "4391",
            "4423",
            "4447",
            "4451",
            "4463",
            "4483",
            "4507",
            "4519",
            "4523",
            "4547",
            "4567",
            "4583",
            "4591",
            "4603",
            "4639",
            "4643",
            "4651",
            "4663",
            "4679",
            "4691",
            "4703",
            "4723",
            "4751",
            "4759",
            "4783",
            "4787",
            "4799",
            "4831",
            "4871",
            "4903",
            "4919",
            "4931",
            "4943",
            "4951",
            "4967",
            "4987",
            "4999",
            "5003",
            "5011",
            "5023",
            "5039",
            "5051",
            "5059",
            "5087",
            "5099",
            "5107",
            "5119",
            "5147",
            "5167",
            "5171",
            "5179",
            "5227",
            "5231",
            "5279",
            "5303",
            "5323",
            "5347",
            "5351",
            "5387",
            "5399",
            "5407",
            "5419",
            "5431",
            "5443",
            "5471",
            "5479",
            "5483",
            "5503",
            "5507",
            "5519",
            "5527",
            "5531",
            "5563",
            "5591",
            "5623",
            "5639",
            "5647",
            "5651",
            "5659",
            "5683",
            "5711",
            "5743",
            "5779",
            "5783",
            "5791",
            "5807",
            "5827",
            "5839",
            "5843",
            "5851",
            "5867",
            "5879",
            "5903",
            "5923",
            "5927",
            "5939",
            "5987",
            "6007",
            "6011",
            "6043",
            "6047",
            "6067",
            "6079",
            "6091",
            "6131",
            "6143",
            "6151",
            "6163",
            "6199",
            "6203",
            "6211",
            "6247",
            "6263",
            "6271",
            "6287",
            "6299",
            "6311",
            "6323",
            "6343",
            "6359",
            "6367",
            "6379",
            "6427",
            "6451",
            "6491",
            "6547",
            "6551",
            "6563",
            "6571",
            "6599",
            "6607",
            "6619",
            "6659",
            "6679",
            "6691",
            "6703",
            "6719",
            "6763",
            "6779",
            "6791",
            "6803",
            "6823",
            "6827",
            "6863",
            "6871",
            "6883",
            "6899",
            "6907",
            "6911",
            "6947",
            "6959",
            "6967",
            "6971",
            "6983",
            "6991",
            "7019",
            "7027",
            "7039",
            "7043",
            "7079",
            "7103",
            "7127",
            "7151",
            "7159",
            "7187",
            "7207",
            "7211",
            "7219",
            "7243",
            "7247",
            "7283",
            "7307",
            "7331",
            "7351",
            "7411",
            "7451",
            "7459",
            "7487",
            "7499",
            "7507",
            "7523",
            "7547",
            "7559",
            "7583",
            "7591",
            "7603",
            "7607",
            "7639",
            "7643",
            "7687",
            "7691",
            "7699",
            "7703",
            "7723",
            "7727",
            "7759",
            "7823",
            "7867"});
            this.ListP.Location = new System.Drawing.Point(147, 43);
            this.ListP.Name = "ListP";
            this.ListP.Size = new System.Drawing.Size(87, 21);
            this.ListP.TabIndex = 12;
            // 
            // ListQ
            // 
            this.ListQ.FormattingEnabled = true;
            this.ListQ.Items.AddRange(new object[] {
            "<-",
            "3",
            "7",
            "11",
            "19",
            "23",
            "31",
            "43",
            "47",
            "59",
            "67",
            "71",
            "79",
            "83",
            "103",
            "107",
            "127",
            "131",
            "139",
            "151",
            "163",
            "167",
            "179",
            "191",
            "199",
            "211",
            "223",
            "227",
            "239",
            "251",
            "263",
            "271",
            "283",
            "307",
            "311",
            "331",
            "347",
            "359",
            "367",
            "379",
            "383",
            "419",
            "431",
            "439",
            "443",
            "463",
            "467",
            "479",
            "487",
            "491",
            "499",
            "503",
            "523",
            "547",
            "563",
            "571",
            "587",
            "599",
            "607",
            "619",
            "631",
            "643",
            "647",
            "659",
            "683",
            "691",
            "719",
            "727",
            "739",
            "743",
            "751",
            "787",
            "811",
            "823",
            "827",
            "839",
            "859",
            "863",
            "883",
            "887",
            "907",
            "911",
            "919",
            "947",
            "967",
            "971",
            "983",
            "991",
            "1019",
            "1031",
            "1039",
            "1051",
            "1063",
            "1087",
            "1091",
            "1103",
            "1123",
            "1151",
            "1163",
            "1171",
            "1187",
            "1223",
            "1231",
            "1259",
            "1279",
            "1283",
            "1291",
            "1303",
            "1307",
            "1319",
            "1327",
            "1367",
            "1399",
            "1423",
            "1427",
            "1439",
            "1447",
            "1451",
            "1459",
            "1471",
            "1483",
            "1487",
            "1499",
            "1511",
            "1523",
            "1531",
            "1543",
            "1559",
            "1567",
            "1571",
            "1579",
            "1583",
            "1607",
            "1619",
            "1627",
            "1663",
            "1667",
            "1699",
            "1723",
            "1747",
            "1759",
            "1783",
            "1787",
            "1811",
            "1823",
            "1831",
            "1847",
            "1867",
            "1871",
            "1879",
            "1907",
            "1931",
            "1951",
            "1979",
            "1987",
            "1999",
            "2003",
            "2011",
            "2027",
            "2039",
            "2063",
            "2083",
            "2087",
            "2099",
            "2111",
            "2131",
            "2143",
            "2179",
            "2203",
            "2207",
            "2239",
            "2243",
            "2251",
            "2267",
            "2287",
            "2311",
            "2339",
            "2347",
            "2351",
            "2371",
            "2383",
            "2399",
            "2411",
            "2423",
            "2447",
            "2459",
            "2467",
            "2503",
            "2531",
            "2539",
            "2543",
            "2551",
            "2579",
            "2591",
            "2647",
            "2659",
            "2663",
            "2671",
            "2683",
            "2687",
            "2699",
            "2707",
            "2711",
            "2719",
            "2731",
            "2767",
            "2791",
            "2803",
            "2819",
            "2843",
            "2851",
            "2879",
            "2887",
            "2903",
            "2927",
            "2939",
            "2963",
            "2971",
            "2999",
            "3011",
            "3019",
            "3023",
            "3067",
            "3079",
            "3083",
            "3119",
            "3163",
            "3167",
            "3187",
            "3191",
            "3203",
            "3251",
            "3259",
            "3271",
            "3299",
            "3307",
            "3319",
            "3323",
            "3331",
            "3343",
            "3347",
            "3359",
            "3371",
            "3391",
            "3407",
            "3463",
            "3467",
            "3491",
            "3499",
            "3511",
            "3527",
            "3539",
            "3547",
            "3559",
            "3571",
            "3583",
            "3607",
            "3623",
            "3631",
            "3643",
            "3659",
            "3671",
            "3691",
            "3719",
            "3727",
            "3739",
            "3767",
            "3779",
            "3803",
            "3823",
            "3847",
            "3851",
            "3863",
            "3907",
            "3911",
            "3919",
            "3923",
            "3931",
            "3943",
            "3947",
            "3967",
            "4003",
            "4007",
            "4019",
            "4027",
            "4051",
            "4079",
            "4091",
            "4099",
            "4111",
            "4127",
            "4139",
            "4159",
            "4211",
            "4219",
            "4231",
            "4243",
            "4259",
            "4271",
            "4283",
            "4327",
            "4339",
            "4363",
            "4391",
            "4423",
            "4447",
            "4451",
            "4463",
            "4483",
            "4507",
            "4519",
            "4523",
            "4547",
            "4567",
            "4583",
            "4591",
            "4603",
            "4639",
            "4643",
            "4651",
            "4663",
            "4679",
            "4691",
            "4703",
            "4723",
            "4751",
            "4759",
            "4783",
            "4787",
            "4799",
            "4831",
            "4871",
            "4903",
            "4919",
            "4931",
            "4943",
            "4951",
            "4967",
            "4987",
            "4999",
            "5003",
            "5011",
            "5023",
            "5039",
            "5051",
            "5059",
            "5087",
            "5099",
            "5107",
            "5119",
            "5147",
            "5167",
            "5171",
            "5179",
            "5227",
            "5231",
            "5279",
            "5303",
            "5323",
            "5347",
            "5351",
            "5387",
            "5399",
            "5407",
            "5419",
            "5431",
            "5443",
            "5471",
            "5479",
            "5483",
            "5503",
            "5507",
            "5519",
            "5527",
            "5531",
            "5563",
            "5591",
            "5623",
            "5639",
            "5647",
            "5651",
            "5659",
            "5683",
            "5711",
            "5743",
            "5779",
            "5783",
            "5791",
            "5807",
            "5827",
            "5839",
            "5843",
            "5851",
            "5867",
            "5879",
            "5903",
            "5923",
            "5927",
            "5939",
            "5987",
            "6007",
            "6011",
            "6043",
            "6047",
            "6067",
            "6079",
            "6091",
            "6131",
            "6143",
            "6151",
            "6163",
            "6199",
            "6203",
            "6211",
            "6247",
            "6263",
            "6271",
            "6287",
            "6299",
            "6311",
            "6323",
            "6343",
            "6359",
            "6367",
            "6379",
            "6427",
            "6451",
            "6491",
            "6547",
            "6551",
            "6563",
            "6571",
            "6599",
            "6607",
            "6619",
            "6659",
            "6679",
            "6691",
            "6703",
            "6719",
            "6763",
            "6779",
            "6791",
            "6803",
            "6823",
            "6827",
            "6863",
            "6871",
            "6883",
            "6899",
            "6907",
            "6911",
            "6947",
            "6959",
            "6967",
            "6971",
            "6983",
            "6991",
            "7019",
            "7027",
            "7039",
            "7043",
            "7079",
            "7103",
            "7127",
            "7151",
            "7159",
            "7187",
            "7207",
            "7211",
            "7219",
            "7243",
            "7247",
            "7283",
            "7307",
            "7331",
            "7351",
            "7411",
            "7451",
            "7459",
            "7487",
            "7499",
            "7507",
            "7523",
            "7547",
            "7559",
            "7583",
            "7591",
            "7603",
            "7607",
            "7639",
            "7643",
            "7687",
            "7691",
            "7699",
            "7703",
            "7723",
            "7727",
            "7759",
            "7823",
            "7867"});
            this.ListQ.Location = new System.Drawing.Point(147, 70);
            this.ListQ.Name = "ListQ";
            this.ListQ.Size = new System.Drawing.Size(87, 21);
            this.ListQ.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(88, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Параметры";
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Location = new System.Drawing.Point(151, 190);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(83, 37);
            this.ButtonHelp.TabIndex = 15;
            this.ButtonHelp.Text = "Помощь";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Десятичная";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Двоичная";
            // 
            // TextResultBin
            // 
            this.TextResultBin.Location = new System.Drawing.Point(382, 19);
            this.TextResultBin.Multiline = true;
            this.TextResultBin.Name = "TextResultBin";
            this.TextResultBin.ReadOnly = true;
            this.TextResultBin.Size = new System.Drawing.Size(136, 208);
            this.TextResultBin.TabIndex = 17;
            this.TextResultBin.WordWrap = false;
            // 
            // TextGamma1
            // 
            this.TextGamma1.Location = new System.Drawing.Point(120, 259);
            this.TextGamma1.Name = "TextGamma1";
            this.TextGamma1.ReadOnly = true;
            this.TextGamma1.Size = new System.Drawing.Size(398, 20);
            this.TextGamma1.TabIndex = 19;
            this.TextGamma1.WordWrap = false;
            // 
            // TextGamma2
            // 
            this.TextGamma2.Location = new System.Drawing.Point(120, 281);
            this.TextGamma2.Name = "TextGamma2";
            this.TextGamma2.ReadOnly = true;
            this.TextGamma2.Size = new System.Drawing.Size(398, 20);
            this.TextGamma2.TabIndex = 20;
            this.TextGamma2.WordWrap = false;
            // 
            // TextGamma3
            // 
            this.TextGamma3.Location = new System.Drawing.Point(120, 307);
            this.TextGamma3.Name = "TextGamma3";
            this.TextGamma3.ReadOnly = true;
            this.TextGamma3.Size = new System.Drawing.Size(398, 20);
            this.TextGamma3.TabIndex = 21;
            this.TextGamma3.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Бит чётности";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Младший бит";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Два младших бита";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Гаммы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 338);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextGamma3);
            this.Controls.Add(this.TextGamma2);
            this.Controls.Add(this.TextGamma1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextResultBin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListQ);
            this.Controls.Add(this.ListP);
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textP);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.TextResult);
            this.Controls.Add(this.textX0);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.textQ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Алгоритм Блюм — Блюма — Шуба";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textQ;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox textX0;
        private System.Windows.Forms.TextBox TextResult;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.TextBox textP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.ComboBox ListP;
        private System.Windows.Forms.ComboBox ListQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextResultBin;
        private System.Windows.Forms.TextBox TextGamma1;
        private System.Windows.Forms.TextBox TextGamma2;
        private System.Windows.Forms.TextBox TextGamma3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

