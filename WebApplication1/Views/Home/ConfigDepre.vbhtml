@Code
    ViewData("Title") = "Config Depreciation"
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If

    Dim lang = "TH"
    If Not Request.QueryString("LANG") Is Nothing Then
        lang = Request.QueryString("LANG")
    End If
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)

    Dim sql As String = "
select p.ProductTypeCode,p.ProductTypeName,
cast (isnull(dbo.GetAccConfig('DEPRE_RATE',p.ProductTypeCode),5) as decimal(10,2)) as TotalYears,
cast(isnull(dbo.GetAccConfig('DEPRE_BASECAP',p.ProductTypeCode),0) as decimal(10,2)) as MaximumValue,
cast(isnull(dbo.GetAccConfig('DEPRE_SCRAPVALUE',p.ProductTypeCode),1) as decimal(10,2)) as ScrapValue
from vMas_ProductType p
where p.IsService=0 
"

    If Request.Form.Count > 0 Then
        Dim productTypeCode = Request.Form("ProductTypeCode").ToString()
        Dim totalYears = Request.Form("TotalYears").ToString()
        Dim maximumValue = Request.Form("MaximumValue").ToString()
        Dim scrapValue = Request.Form("ScrapValue").ToString()
        Dim sqlUpdate As String = "
IF EXISTS (SELECT 1 FROM Mas_AccConfig WHERE ConfigCode='DEPRE_RATE' AND ConfigKey='{0}')
BEGIN
    UPDATE Mas_AccConfig SET ConfigValue='{1}' WHERE ConfigCode='DEPRE_RATE' AND ConfigKey='{0}'
END
ELSE
BEGIN
    INSERT INTO Mas_AccConfig (ConfigCode, ConfigKey, ConfigValue) VALUES ('DEPRE_RATE', '{0}', '{1}')
END
"
        obj.ExecuteSQL(String.Format(sqlUpdate, productTypeCode, totalYears))
        sqlUpdate = "
IF EXISTS (SELECT 1 FROM Mas_AccConfig WHERE ConfigCode='DEPRE_BASECAP' AND ConfigKey='{0}')
BEGIN
    UPDATE Mas_AccConfig SET ConfigValue='{1}' WHERE ConfigCode='DEPRE_BASECAP' AND ConfigKey='{0}'
END
ELSE
BEGIN
    INSERT INTO Mas_AccConfig (ConfigCode, ConfigKey, ConfigValue) VALUES ('DEPRE_BASECAP', '{0}', '{1}')
END
"
        obj.ExecuteSQL(String.Format(sqlUpdate, productTypeCode, maximumValue))
        sqlUpdate = "
IF EXISTS (SELECT 1 FROM Mas_AccConfig WHERE ConfigCode='DEPRE_SCRAPVALUE' AND ConfigKey='{0}')
BEGIN
    UPDATE Mas_AccConfig SET ConfigValue='{1}' WHERE ConfigCode='DEPRE_SCRAPVALUE' AND ConfigKey='{0}'
END
ELSE
BEGIN
    INSERT INTO Mas_AccConfig (ConfigCode, ConfigKey, ConfigValue) VALUES ('DEPRE_SCRAPVALUE', '{0}', '{1}')
END
"
        obj.ExecuteSQL(String.Format(sqlUpdate, productTypeCode, scrapValue))
        Response.Write("Configuration saved successfully.")
        Response.End()
    End If
End Code
@if lang = "TH" Then
    @<h2>ตั้งค่าการคำนวณค่าเสื่อมราคา</h2>
Else
    @<h2>Config Depreciation</h2>
End If
<table class="table table-responsive">
    @If lang = "TH" Then
        @<thead>
            <tr>
                <th>ประเภททรัพย์สิน</th>
                <th>ชื่อประเภททรัพย์สิน</th>
                <th>อายุการใช้งาน(ปี)</th>
                <th>มูลค่าสูงสุด</th>
                <th>ราคาซาก</th>
                <th>บันทึก</th>
            </tr>
        </thead>
    Else
        @<thead>
            <tr>
                <th>Product Type</th>
                <th>Product Type Name</th>
                <th>Total Years</th>
                <th>Maximum Value</th>
                <th>Scrap Value</th>
                <th>Action</th>
            </tr>
        </thead>

    End If
    <tbody>
        @If obj.IsConnect Then
            Dim dt As New Data.DataTable
            dt = obj.GetDataFromSQL(sql)
            Dim i As Integer = 0
            For Each dr As Data.DataRow In dt.Rows
                i += 1
                Dim ctl1 = "txtTotalYears" & i
                Dim ctl2 = "txtMaximumValue" & i
                Dim ctl3 = "txtScrapValue" & i
                @<tr>
                    <td>
                        @dr("ProductTypeCode").ToString()
                    </td>
                    <td>
                        @dr("ProductTypeName").ToString()
                    </td>
                    <td>
                        <input type="number" class="form-control" id="@ctl1" value="@dr("TotalYears")" />
                    </td>
                    <td>
                        <input type="number" class="form-control" id="@ctl2" value="@dr("MaximumValue")" />
                    </td>
                    <td>
                        <input type="number" class="form-control" id="@ctl3" value="@dr("ScrapValue")" />
                    </td>
                    <td>
                        <button class="btn btn-primary" onclick="SaveConfig('@dr("ProductTypeCode").ToString()','@ctl1','@ctl2','@ctl3')">Save</button>
                    </td>
                </tr>
            Next
        End If
    </tbody>
</table>
<script type="text/javascript">
    function SaveConfig(productTypeCode,ctl1,ctl2,ctl3) {
        var totalYears = $("#" + ctl1).val();
        var maximumValue = $("#" + ctl2).val();
        var scrapValue = $("#" + ctl3).val();
        $.ajax({
            url: "?Form=ConfigDepre&DB=@dbname&SRC=@dbSource",
            type: "POST",
            data: {
                ProductTypeCode: productTypeCode,
                TotalYears: totalYears,
                MaximumValue: maximumValue,
                ScrapValue: scrapValue
            },
            success: function (response) {
                alert(response);
            },
            error: function (xhr, status, error) {
                alert("Error: " + error);
            }
        });
    }
</script>