Namespace AggregateFunctionCalcFieldExample

    Partial Class TestReport

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AggregateFunctionCalcFieldExample.TestReport))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.calcTotalRevenueByCategory = New DevExpress.XtraReports.UI.CalculatedField()
            Me.calcRevenuePercentage = New DevExpress.XtraReports.UI.CalculatedField()
            Me.calcAggregatedValue = New DevExpress.XtraReports.UI.CalculatedField()
            Me.calcRevenue = New DevExpress.XtraReports.UI.CalculatedField()
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
            Me.Detail.HeightF = 27.49999F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BorderColor = System.Drawing.Color.LightGray
            Me.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650.0001F, 27.49999F)
            Me.xrTable1.StylePriority.UseBorderColor = False
            Me.xrTable1.StylePriority.UseBorders = False
            Me.xrTable1.StylePriority.UseTextAlignment = False
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.BackColor = System.Drawing.Color.White
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell12, Me.xrTableCell5})
            Me.xrTableRow1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "IIF(Not[Discontinued] And [UnitsInStock]*[UnitPrice] >= 500,'Red','Black')")})
            Me.xrTableRow1.ForeColor = System.Drawing.Color.Black
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.StylePriority.UseBackColor = False
            Me.xrTableRow1.StylePriority.UseForeColor = False
            Me.xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
            Me.xrTableCell1.StylePriority.UsePadding = False
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.xrTableCell1.Weight = 0.66666666666666663R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuantityPerUnit]")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell2.Weight = 0.66666666666666663R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell3.TextFormatString = "{0:$0.00}"
            Me.xrTableCell3.Weight = 0.4743588539740734R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsInStock]")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell4.Weight = 0.65901770057465314R
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calcRevenue]")})
            Me.xrTableCell12.Multiline = True
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.StylePriority.UseTextAlignment = False
            Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell12.TextFormatString = "{0:$0.00}"
            Me.xrTableCell12.Weight = 0.486240755463335R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[calcRevenuePercentage]")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrTableCell5.StylePriority.UsePadding = False
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell5.TextFormatString = "{0:0.00%}"
            Me.xrTableCell5.Weight = 0.89747682646364879R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.PageHeader.HeightF = 25F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.xrTable2.Font = New System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 25F)
            Me.xrTable2.StylePriority.UseBackColor = False
            Me.xrTable2.StylePriority.UseFont = False
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell6, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell11, Me.xrTableCell10})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 11.5R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100F)
            Me.xrTableCell6.StylePriority.UsePadding = False
            Me.xrTableCell6.StylePriority.UseTextAlignment = False
            Me.xrTableCell6.Text = "Product Name"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell6.Weight = 0.66666666666666663R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.StylePriority.UseTextAlignment = False
            Me.xrTableCell7.Text = "Qty Per Unit"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell7.Weight = 0.66666666666666663R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.StylePriority.UseTextAlignment = False
            Me.xrTableCell8.Text = "Unit Price"
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell8.Weight = 0.47435897435897434R
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.StylePriority.UseTextAlignment = False
            Me.xrTableCell9.Text = "Units In Stock"
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell9.Weight = 0.65901745824839109R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.Multiline = True
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.StylePriority.UseTextAlignment = False
            Me.xrTableCell11.Text = "Revenue"
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell11.Weight = 0.48624156135126684R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrTableCell10.StylePriority.UsePadding = False
            Me.xrTableCell10.StylePriority.UseTextAlignment = False
            Me.xrTableCell10.Text = "Category Revenue Percentage"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.xrTableCell10.Weight = 0.89747623180258551R
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel4, Me.xrLabel3, Me.xrLabel1})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CategoryID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
            Me.GroupHeader1.HeightF = 93.75F
            Me.GroupHeader1.Name = "GroupHeader1"
            Me.GroupHeader1.StylePriority.UseBorders = False
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0F, 45.99997F)
            Me.xrLabel4.Multiline = True
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(639.9999F, 47.75003F)
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UsePadding = False
            Me.xrLabel4.Text = "* The number of entries in this category that are not discontinued with revenue g" & "reater than $500 (highlighted in red)"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.BackColor = System.Drawing.Color.LightGray
            Me.xrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "'Aggregated value* for this category: ' + [calcAggregatedValue]")})
            Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 22.99999F)
            Me.xrLabel3.Multiline = True
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(640F, 23F)
            Me.xrLabel3.StylePriority.UseBackColor = False
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UsePadding = False
            Me.xrLabel3.Text = " "
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.xrLabel1.ForeColor = System.Drawing.Color.Orange
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 5, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(190.5776F, 23F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.Text = "CategoryID: [CategoryID]"
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2})
            Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
            Me.GroupFooter1.HeightF = 45.83334F
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.StylePriority.UseBorders = False
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "'Total: ' + FormatString('{0:c}',[calcTotalRevenueByCategory])")})
            Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold)
            Me.xrLabel2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((128)))))), (CInt(((CByte((255)))))))
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(305.1609F, 22.83335F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(193.334F, 23F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "ProductID"
            table1.Name = "Products"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "ProductName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "SupplierID"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "CategoryID"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "QuantityPerUnit"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "UnitPrice"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "UnitsInStock"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "UnitsOnOrder"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "ReorderLevel"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Discontinued"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "EAN13"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Columns.Add(column9)
            selectQuery1.Columns.Add(column10)
            selectQuery1.Columns.Add(column11)
            selectQuery1.Name = "Products"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' calcTotalRevenueByCategory
            ' 
            Me.calcTotalRevenueByCategory.DataMember = "Products"
            Me.calcTotalRevenueByCategory.Expression = "[][[CategoryID] == [^.CategoryID]].Sum([calcRevenue])"
            Me.calcTotalRevenueByCategory.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
            Me.calcTotalRevenueByCategory.Name = "calcTotalRevenueByCategory"
            ' 
            ' calcRevenuePercentage
            ' 
            Me.calcRevenuePercentage.DataMember = "Products"
            Me.calcRevenuePercentage.DisplayName = "calcRevenuePercentage"
            Me.calcRevenuePercentage.Expression = "[calcRevenue] / [calcTotalRevenueByCategory]"
            Me.calcRevenuePercentage.FieldType = DevExpress.XtraReports.UI.FieldType.[Double]
            Me.calcRevenuePercentage.Name = "calcRevenuePercentage"
            ' 
            ' calcAggregatedValue
            ' 
            Me.calcAggregatedValue.DataMember = "Products"
            Me.calcAggregatedValue.Expression = "[][[CategoryID] == [^.CategoryID] And Not[Discontinued] And [calcRevenue] >= 500]" & ".Count()"
            Me.calcAggregatedValue.Name = "calcAggregatedValue"
            ' 
            ' calcRevenue
            ' 
            Me.calcRevenue.DataMember = "Products"
            Me.calcRevenue.Expression = "[UnitPrice]*[UnitsInStock]"
            Me.calcRevenue.Name = "calcRevenue"
            ' 
            ' TestReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1, Me.GroupFooter1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.calcTotalRevenueByCategory, Me.calcRevenuePercentage, Me.calcAggregatedValue, Me.calcRevenue})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.Version = "21.2"
            CType((Me.xrTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xrTable2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private xrTable1 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private xrTable2 As DevExpress.XtraReports.UI.XRTable

        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow

        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell11 As DevExpress.XtraReports.UI.XRTableCell

        Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell

        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private calcTotalRevenueByCategory As DevExpress.XtraReports.UI.CalculatedField

        Private calcRevenuePercentage As DevExpress.XtraReports.UI.CalculatedField

        Private calcAggregatedValue As DevExpress.XtraReports.UI.CalculatedField

        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel

        Private calcRevenue As DevExpress.XtraReports.UI.CalculatedField
    End Class
End Namespace
