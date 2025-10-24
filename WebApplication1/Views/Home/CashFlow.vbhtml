@Code
    ViewBag.Title="Cash Flow"

    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If

    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If

    Dim period =DateTime.Now.Year()
    if Not Request.QueryString("Period") Is Nothing Then
        period=Request.QueryString("Period")
    End If
    Dim obj=New AccReport.CUtil(".",dbSource)
    Dim sql=String.Format("EXEC dbo.GetCashFlow {0}",period)
    Dim dt as New Data.DataTable()
    dt=obj.GetDataFromSQL(sql)
End Code
<h3>งบกระแสเงินสด แบบทางตรง</h3>
<b>ประจำงวด :</b> @period 
@If dt.Rows.Count>0 Then
    For Each dr as Data.DataRow In dt.Rows
        @<div class="row">
            <div class="col-sm-6">                
                @If dr("lvl")=0 Or dr("lvl")>2 Then
                    @<b>@dr("AccDesc")</b>
                Else
                    If dr("CashIn")>0 Then
                        @<b><u>+</u></b>
                    Else
                        @<b><u>-</u></b>
                    End If
                    @<span>@dr("AccDesc")</span>
                End If
            </div>        
            <div class="col-sm-3" style="text-align:right;">
                @If dr("lvl")=0 Or dr("lvl")>2 Then                    
                    @<b>@dr("CashIn")</b>
                Else
                    @<span>@dr("CashIn")</span>
                End If
            </div>
            <div class="col-sm-3" style="text-align:right;">
                @If dr("lvl")=0 Or dr("lvl")>2 Then                    
                    @<b>@dr("CashOut")</b>
                Else
                    @<span>@dr("CashOut")</span>
                End If
            </div>
        </div>
    Next
End If 