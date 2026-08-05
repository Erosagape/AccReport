@Code
    Layout = Nothing
    ViewData("Title") = "Menu"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
    Dim dateFrom = New Date(DateTime.Now.Year, Now.Month, 1)
    Dim dateTo = DateAdd("d", -1, New Date(DateTime.Now.Year, Now.Month + 1, 1))
    Dim obj = New AccReport.CUtil(ViewBag.WebIP, dbSource)
    If ViewBag.User = "" Then
        Response.Redirect("~/Home/Login?RedirectTo=/AccReport?Form=MenuDesktop&DB=" + dbname + "&SRC=" + dbSource)
    End If
End Code
<!DOCTYPE html>
<html lang="th">
<head>
    <base target="_top">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Accounting Workflow</title>

    <!-- Google Material Symbols -->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Noto+Sans+Thai:wght@400;500;600;700;800&family=Material+Symbols+Rounded:FILL@0..1&display=swap" rel="stylesheet">

    <style>
        :root {
            --page-bg-1: #f7faff;
            --page-bg-2: #eef4fc;
            --ink: #17315b;
            --muted: #667893;
            --white: rgba(255,255,255,.84);
            --line: rgba(93,132,185,.20);
            --shadow-lg: 0 26px 65px rgba(45,77,124,.16);
            --shadow-md: 0 14px 30px rgba(45,77,124,.14);
            --shadow-sm: 0 7px 18px rgba(45,77,124,.12);
        }

        * {
            box-sizing: border-box;
        }

        html, body {
            min-height: 100%;
            margin: 0;
            font-family: "Noto Sans Thai", system-ui, sans-serif;
            color: var(--ink);
            background: radial-gradient(circle at 12% 9%, rgba(102,174,255,.19), transparent 22%), radial-gradient(circle at 86% 12%, rgba(183,131,255,.13), transparent 22%), linear-gradient(145deg, var(--page-bg-1), var(--page-bg-2));
        }

        body {
            padding: clamp(18px, 2.5vw, 38px);
            overflow-x: hidden;
        }

        button, a {
            font: inherit;
        }

        .app-shell {
            width: min(1700px, 100%);
            margin: 0 auto;
        }

        .topbar {
            display: flex;
            align-items: center;
            justify-content: space-between;
            gap: 18px;
            margin-bottom: 22px;
        }

        .brand-block h1 {
            margin: 0;
            font-size: clamp(22px, 2.2vw, 35px);
            line-height: 1.2;
            font-weight: 800;
            letter-spacing: -.02em;
        }

        .brand-block p {
            margin: 5px 0 0;
            color: var(--muted);
            font-size: 14px;
        }

        .demo-badge {
            padding: 10px 16px;
            border-radius: 999px;
            color: #2f65b5;
            font-weight: 700;
            font-size: 13px;
            background: rgba(255,255,255,.72);
            border: 1px solid rgba(84,137,206,.20);
            box-shadow: var(--shadow-sm);
            white-space: nowrap;
        }

        /* Exact circles: fixed square ratio, never oval */
        .module-nav-wrap {
            position: relative;
            padding: 14px 6px 30px;
        }

        .module-nav {
            display: grid;
            grid-template-columns: repeat(8, minmax(112px, 1fr));
            gap: clamp(10px, 1.3vw, 22px);
            align-items: start;
        }

        .module-button {
            --accent: #1f7cff;
            --accent-rgb: 31,124,255;
            appearance: none;
            border: 0;
            background: transparent;
            padding: 0;
            color: inherit;
            cursor: pointer;
            min-width: 0;
            text-align: center;
            outline: none;
        }

        .module-circle {
            width: clamp(100px, 9.8vw, 156px);
            aspect-ratio: 1 / 1;
            height: auto;
            margin: 0 auto;
            border-radius: 50%;
            position: relative;
            isolation: isolate;
            display: flex;
            align-items: center;
            justify-content: center;
            background: radial-gradient(circle at 35% 24%, rgba(255,255,255,.98), rgba(255,255,255,.72) 34%, rgba(var(--accent-rgb),.10) 100%);
            border: 3px solid rgba(var(--accent-rgb),.28);
            box-shadow: inset 0 0 0 5px rgba(255,255,255,.66), inset 0 -12px 22px rgba(var(--accent-rgb),.08), 0 15px 28px rgba(45,77,124,.13);
            transition: transform .28s ease, box-shadow .28s ease, border-color .28s ease;
        }

            .module-circle::before {
                content: "";
                position: absolute;
                inset: 7px;
                border-radius: 50%;
                z-index: -1;
                background: linear-gradient(145deg, rgba(255,255,255,.58), rgba(var(--accent-rgb),.05));
                box-shadow: inset 0 1px 1px rgba(255,255,255,.95);
            }

            .module-circle::after {
                content: "";
                position: absolute;
                width: 48%;
                height: 18%;
                top: 9%;
                left: 26%;
                border-radius: 50%;
                background: rgba(255,255,255,.62);
                filter: blur(8px);
                transform: rotate(-8deg);
                pointer-events: none;
            }

        .module-inner {
            width: 78%;
            display: grid;
            justify-items: center;
            gap: 3px;
            position: relative;
            z-index: 2;
        }

        .module-number {
            font-size: clamp(17px, 1.55vw, 26px);
            line-height: 1;
            color: var(--accent);
            font-weight: 800;
        }

        .module-icon {
            font-family: "Material Symbols Rounded";
            font-variation-settings: "FILL" 1, "wght" 600, "GRAD" 0, "opsz" 48;
            font-size: clamp(35px, 3.4vw, 54px);
            line-height: 1;
            color: var(--accent);
            filter: drop-shadow(0 7px 8px rgba(var(--accent-rgb),.20));
            margin: 2px 0 3px;
        }

        .module-th {
            font-size: clamp(12px, 1vw, 16px);
            line-height: 1.25;
            font-weight: 700;
        }

        .module-en {
            font-size: clamp(10px, .82vw, 13px);
            line-height: 1.15;
            font-weight: 600;
            color: var(--accent);
        }

        .module-button:hover .module-circle {
            transform: translateY(-7px) scale(1.025);
            border-color: rgba(var(--accent-rgb),.58);
            box-shadow: inset 0 0 0 5px rgba(255,255,255,.72), inset 0 -12px 22px rgba(var(--accent-rgb),.10), 0 20px 35px rgba(var(--accent-rgb),.20);
        }

        .module-button.active .module-circle {
            transform: translateY(-8px) scale(1.055);
            border-color: rgba(var(--accent-rgb),.86);
            box-shadow: inset 0 0 0 5px rgba(255,255,255,.78), inset 0 -13px 22px rgba(var(--accent-rgb),.14), 0 0 0 5px rgba(var(--accent-rgb),.10), 0 0 28px rgba(var(--accent-rgb),.34), 0 23px 42px rgba(var(--accent-rgb),.20);
        }

        .active-pointer {
            width: 0;
            height: 0;
            border-left: 13px solid transparent;
            border-right: 13px solid transparent;
            border-bottom: 17px solid var(--active-color, #1f7cff);
            position: absolute;
            bottom: 0;
            left: var(--pointer-x, 6.25%);
            transform: translateX(-50%);
            filter: drop-shadow(0 -3px 5px rgba(31,124,255,.18));
            transition: left .36s cubic-bezier(.2,.8,.2,1), border-bottom-color .25s ease;
        }

        .panel {
            --accent: #1f7cff;
            --accent-rgb: 31,124,255;
            position: relative;
            border-radius: 32px;
            border: 1px solid rgba(var(--accent-rgb),.27);
            background: linear-gradient(145deg, rgba(255,255,255,.91), rgba(245,249,255,.77));
            box-shadow: inset 0 1px 0 rgba(255,255,255,.98), inset 0 0 35px rgba(var(--accent-rgb),.05), var(--shadow-lg);
            backdrop-filter: blur(15px);
            overflow: hidden;
            animation: panelIn .36s ease;
        }

        @@keyframes panelIn {
            from {
                opacity: 0;
                transform: translateY(-10px) scale(.992);
            }

            to {
                opacity: 1;
                transform: translateY(0) scale(1);
            }
        }

        .panel::before {
            content: "";
            position: absolute;
            inset: 0;
            pointer-events: none;
            background: radial-gradient(circle at 11% 20%, rgba(var(--accent-rgb),.09), transparent 25%), linear-gradient(115deg, transparent 0 70%, rgba(var(--accent-rgb),.035) 70% 100%);
        }

        .panel-grip {
            width: 118px;
            height: 38px;
            position: absolute;
            top: -1px;
            left: 50%;
            transform: translateX(-50%);
            border-radius: 0 0 22px 22px;
            border: 1px solid rgba(var(--accent-rgb),.18);
            border-top: 0;
            background: rgba(255,255,255,.87);
            box-shadow: 0 8px 18px rgba(45,77,124,.10);
            display: grid;
            place-items: center;
            z-index: 3;
        }

            .panel-grip .material-symbols-rounded {
                color: var(--accent);
                font-size: 26px;
            }

        .panel-content {
            display: grid;
            grid-template-columns: minmax(0, 1fr) 340px;
            gap: 30px;
            padding: 48px 38px 34px;
            position: relative;
            z-index: 2;
        }

        .main-area {
            min-width: 0;
        }

        .panel-heading {
            display: flex;
            align-items: center;
            gap: 17px;
            padding-bottom: 19px;
            border-bottom: 1px solid rgba(var(--accent-rgb),.22);
        }

        .heading-icon {
            width: 74px;
            height: 74px;
            border-radius: 22px;
            display: grid;
            place-items: center;
            color: #fff;
            background: linear-gradient(145deg, rgba(var(--accent-rgb),.72), var(--accent));
            box-shadow: inset 0 1px 2px rgba(255,255,255,.55), inset 0 -7px 12px rgba(0,0,0,.08), 0 13px 24px rgba(var(--accent-rgb),.25);
            flex: 0 0 auto;
        }

            .heading-icon .material-symbols-rounded {
                font-size: 43px;
                font-variation-settings: "FILL" 1, "wght" 600, "GRAD" 0, "opsz" 48;
            }

        .panel-heading h2 {
            margin: 0;
            font-size: clamp(24px, 2.2vw, 37px);
            line-height: 1.15;
            color: var(--accent);
        }

        .panel-heading p {
            margin: 5px 0 0;
            color: var(--muted);
            font-size: 14px;
        }

        .workflow-grid {
            display: grid;
            grid-template-columns: repeat(var(--step-count, 4), minmax(125px, 1fr));
            gap: 28px;
            margin-top: 33px;
        }

        .step-card {
            min-height: 258px;
            border-radius: 25px;
            position: relative;
            padding: 28px 14px 19px;
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            text-align: center;
            background: linear-gradient(145deg, rgba(255,255,255,.95), rgba(244,248,255,.82));
            border: 1px solid rgba(var(--accent-rgb),.14);
            box-shadow: inset 0 1px 1px rgba(255,255,255,.95), inset 0 -8px 20px rgba(var(--accent-rgb),.035), 0 13px 25px rgba(45,77,124,.11);
            transition: transform .24s ease, box-shadow .24s ease;
        }

            .step-card:hover {
                transform: translateY(-7px);
                box-shadow: inset 0 1px 1px rgba(255,255,255,.95), inset 0 -8px 20px rgba(var(--accent-rgb),.05), 0 20px 34px rgba(var(--accent-rgb),.17);
            }

            .step-card:not(:last-child)::after {
                content: "arrow_forward";
                font-family: "Material Symbols Rounded";
                font-size: 36px;
                color: rgba(var(--accent-rgb),.55);
                position: absolute;
                right: -34px;
                top: 50%;
                transform: translateY(-50%);
                z-index: 5;
                filter: drop-shadow(0 4px 4px rgba(var(--accent-rgb),.14));
            }

        .step-number {
            position: absolute;
            left: 15px;
            top: 14px;
            width: 31px;
            height: 31px;
            border-radius: 50%;
            display: grid;
            place-items: center;
            color: #fff;
            font-weight: 800;
            background: linear-gradient(145deg, rgba(var(--accent-rgb),.70), var(--accent));
            box-shadow: 0 6px 12px rgba(var(--accent-rgb),.23);
        }

        .step-icon {
            font-family: "Material Symbols Rounded";
            font-variation-settings: "FILL" 1, "wght" 550, "GRAD" 0, "opsz" 48;
            font-size: clamp(64px, 6.4vw, 100px);
            line-height: 1;
            color: var(--accent);
            margin-bottom: 22px;
            text-shadow: 0 2px 0 rgba(255,255,255,.82);
            filter: drop-shadow(0 14px 10px rgba(var(--accent-rgb),.16)) drop-shadow(0 3px 1px rgba(255,255,255,.95));
        }

        .step-th {
            font-size: clamp(15px, 1.22vw, 20px);
            font-weight: 700;
            line-height: 1.3;
        }

        .step-en {
            margin-top: 4px;
            color: var(--accent);
            font-weight: 700;
            font-size: 14px;
        }

        .quick-area {
            border-left: 1px solid rgba(var(--accent-rgb),.17);
            padding-left: 30px;
            display: flex;
            flex-direction: column;
            justify-content: center;
        }

        .quick-title {
            font-size: 15px;
            color: var(--muted);
            font-weight: 700;
            margin: 0 0 12px 3px;
        }

        .quick-list {
            display: grid;
            gap: 12px;
        }

        .quick-button {
            border: 1px solid rgba(var(--accent-rgb),.12);
            border-radius: 18px;
            min-height: 72px;
            padding: 10px 14px;
            background: rgba(255,255,255,.74);
            box-shadow: inset 0 1px 0 rgba(255,255,255,.95), 0 9px 18px rgba(45,77,124,.09);
            display: grid;
            grid-template-columns: 49px 1fr 26px;
            gap: 13px;
            align-items: center;
            text-align: left;
            color: var(--ink);
            cursor: pointer;
            transition: transform .2s ease, border-color .2s ease, box-shadow .2s ease;
        }

            .quick-button:hover {
                transform: translateX(5px);
                border-color: rgba(var(--accent-rgb),.38);
                box-shadow: 0 12px 22px rgba(var(--accent-rgb),.13);
            }

        .quick-icon {
            width: 47px;
            height: 47px;
            border-radius: 14px;
            display: grid;
            place-items: center;
            background: linear-gradient(145deg, rgba(var(--accent-rgb),.73), var(--accent));
            color: #fff;
            box-shadow: 0 8px 15px rgba(var(--accent-rgb),.20);
        }

            .quick-icon .material-symbols-rounded {
                font-size: 26px;
                font-variation-settings: "FILL" 1, "wght" 550, "GRAD" 0, "opsz" 32;
            }

        .quick-label {
            font-size: 15px;
            font-weight: 700;
            line-height: 1.25;
        }

        .quick-arrow {
            font-family: "Material Symbols Rounded";
            color: var(--accent);
            font-size: 25px;
        }

        .toast {
            position: fixed;
            left: 50%;
            bottom: 24px;
            transform: translate(-50%, 18px);
            padding: 12px 18px;
            border-radius: 999px;
            color: #fff;
            font-size: 13px;
            font-weight: 700;
            background: rgba(23,49,91,.93);
            box-shadow: 0 15px 35px rgba(23,49,91,.24);
            opacity: 0;
            pointer-events: none;
            transition: .25s ease;
            z-index: 20;
        }

            .toast.show {
                opacity: 1;
                transform: translate(-50%, 0);
            }

        @@media (max-width: 1280px) {
            .module-nav {
                grid-template-columns: repeat(4, 1fr);
                row-gap: 20px;
            }

            .active-pointer {
                display: none;
            }

            .panel-content {
                grid-template-columns: 1fr;
            }

            .quick-area {
                border-left: 0;
                border-top: 1px solid rgba(var(--accent-rgb),.17);
                padding: 25px 0 0;
            }

            .quick-list {
                grid-template-columns: repeat(2, 1fr);
            }
        }

        @@media (max-width: 900px) {
            body {
                padding: 16px;
            }

            .topbar {
                align-items: flex-start;
            }

            .module-nav {
                display: flex;
                overflow-x: auto;
                scroll-snap-type: x mandatory;
                padding: 4px 5px 18px;
            }

            .module-button {
                flex: 0 0 122px;
                scroll-snap-align: center;
            }

            .module-circle {
                width: 112px;
            }

            .panel-content {
                padding: 45px 20px 25px;
                gap: 22px;
            }

            .workflow-grid {
                grid-template-columns: repeat(2, minmax(0, 1fr));
                gap: 18px;
            }

            .step-card:not(:last-child)::after {
                display: none;
            }

            .quick-list {
                grid-template-columns: 1fr;
            }
        }

        @@media (max-width: 560px) {
            .brand-block p, .demo-badge {
                display: none;
            }

            .workflow-grid {
                grid-template-columns: 1fr;
            }

            .step-card {
                min-height: 215px;
            }

            .heading-icon {
                width: 60px;
                height: 60px;
                border-radius: 18px;
            }

                .heading-icon .material-symbols-rounded {
                    font-size: 35px;
                }
        }
    </style>
</head>

<body>
    <main class="app-shell">
        <header class="topbar">
            <div class="brand-block">
                <h1>Welcome @ViewBag.User</h1>
            </div>
        </header>

        <section class="module-nav-wrap" aria-label="เมนูหลัก">
            <div id="moduleNav" class="module-nav"></div>
            <div id="activePointer" class="active-pointer"></div>
        </section>

        <section id="detailPanel" class="panel" aria-live="polite">
            <div class="panel-grip">
                <span class="material-symbols-rounded">keyboard_arrow_down</span>
            </div>

            <div class="panel-content">
                <div class="main-area">
                    <div class="panel-heading">
                        <div class="heading-icon">
                            <span id="headingIcon" class="material-symbols-rounded"></span>
                        </div>
                        <div>
                            <h2 id="panelTitle"></h2>
                            <p id="panelDescription"></p>
                        </div>
                    </div>

                    <div id="workflowGrid" class="workflow-grid"></div>
                </div>

                <aside class="quick-area">
                    <div class="quick-title">เมนูการทำงาน</div>
                    <div id="quickList" class="quick-list"></div>
                </aside>
            </div>
        </section>
    </main>

    <div id="toast" class="toast"></div>

    <script>
        const modules = [
            {
                id: 1,
                th: "ซื้อ",
                en: "Purchase",
                color: "#1677ff",
                rgb: "22,119,255",
                icon: "assignment",
                description: "กระบวนการจัดซื้อสินค้าและบริการ",
                steps: [
                    ["assignment", "ขอซื้อสินค้า", "PR", "accmain/PurchaseRequisition"],
                    ["shopping_cart_checkout", "ใบสั่งซื้อ", "PO", "accmain/CashPurchaseOrder"],
                    ["local_shipping", "รับสินค้า", "DI", "accmain/DeliveryIn"],
                    ["request_quote", "ใบรับวางบิล", "PI", "accmain/PaymentInputNote"]
                ],
                actions: [
                    ["add_box", "สร้างรายการใหม่", "accmobile/AccordionPR?accDocType=PR"],
                    ["cloud_upload", "อัปโหลดเอกสาร","accmobile"],
                    ["fact_check", "ดูสถานะ", "accmobile/PurchaseRequisition"],
                    ["search", "ค้นหาเอกสาร", "accmobile/CreditPurchaseOrder"],
                    ["monitoring", "รายงานยอดซื้อ","accreport/?Form=ReportPurchase&SRC=@dbSource&DB=@dbName"]
                ]
            },
            {
                id: 2,
                th: "ขาย",
                en: "Sales",
                color: "#28a447",
                rgb: "40,164,71",
                icon: "trending_up",
                description: "กระบวนการขายและส่งมอบสินค้า",
                steps: [
                    ["description", "ใบเสนอราคา", "SR", "accmain/SalesRequisition"],
                    ["order_approve", "ใบสั่งขาย", "SO", "accmain/CashSalesOrder"],
                    ["local_shipping", "ส่งสินค้า", "DO", "accmain/DeliveryOut"],
                    ["receipt_long", "ใบแจ้งหนี้", "SI", "accmain/SalesInvoice"]
                ],
                actions: [
                    ["add_box", "สร้างรายการขาย", "accmobile/AccordionSR?accDocType=SR"],
                    ["cloud_upload", "อัปโหลดเอกสาร","accmobile"],
                    ["fact_check", "ดูสถานะการขาย", "accmobile/CreditSalesOrder"],
                    ["search", "ใบแจ้งหนี้", "accmobile/SalesInvoice"],
                    ["monitoring", "รายงานยอดขาย","accreport/?Form=ReportSale&SRC=@dbSource&DB=@dbName"]
                ]
            },
            {
                id: 3,
                th: "คลังสินค้า",
                en: "Inventory",
                color: "#ff8614",
                rgb: "255,134,20",
                icon: "warehouse",
                description: "ควบคุมสินค้า คลัง และยอดคงเหลือ",
                steps: [
                    ["warehouse", "คลังสินค้า", "Warehouse", "accmobile/Warehouses"],
                    ["inventory_2", "รับ–จ่ายสินค้า", "Stock Movement", "accmobile/StockTransaction"],
                    ["inventory", "ตรวจนับ", "Stock Count","accmobile"],
                    ["checklist", "ปรับปรุงสต็อก", "Stock Adjust","accmobile"]
                ],
                actions: [
                    ["add_box", "สต๊อกการ์ด","accreport/?Form=StockCard&SRC=@dbSource&DB=@dbName"],
                    ["qr_code_scanner", "ใบรับสินค้า","accmobile/DeliveryIn"],
                    ["inventory", "ใบเบิกสินค้า","accmobile/DeliveryOut"],
                    ["search", "ค้นหาสินค้า","accreport/?Form=StockOnhand&SRC=@dbSource&DB=@dbName"],
                    ["monitoring", "รายงานคลังสินค้า","accreport/?Form=ReportStock&SRC=@dbSource&DB=@dbName"]
                ]
            },
            {
                id: 4,
                th: "รับ/จ่าย",
                en: "Payments",
                color: "#0fa4af",
                rgb: "15,164,175",
                icon: "account_balance_wallet",
                description: "บริหารการรับเงิน จ่ายเงิน และธนาคาร",
                steps: [
                    ["payments", "รับชำระเงิน", "Receive", "accmain/ReceiveVoucher"],
                    ["receipt", "ออกใบเสร็จรับเงิน", "Receipt", "accmain/ReceiveConfirm"],
                    ["account_balance_wallet", "จ่ายชำระเงิน", "Payment", "accmain/PaymentConfirm"],
                    ["account_balance", "เช็ค / ธนาคาร", "Cheque" , "accmain/PaymentVoucher"],
                    ["paid", "ค่าใช้จ่าย / เงินสดย่อย", "Expense", "accmain/JournalEntries"]
                ],
                actions: [
                    ["add_box", "สร้างรายการรับ", "accmobile/AccordionRC?accDocType=RC"],
                    ["cloud_upload", "สร้างรายการจ่าย","accmobile/AccordionPC?accDocType=PC"],
                    ["fact_check", "ใบเสร็จค่าใช้จ่าย","accmobile/PaymentConfirm"],
                    ["search", "ใบเสร็จรับเงิน","accmobile/ReceiveConfirm"],
                    ["monitoring", "รายงานกระแสเงินสด","accreport/?Form=CashFlow&DateFrom=@dateFrom.ToString("yyyy-MM-dd")&DateTo=@dateTo.ToString("yyyy-MM-dd")&SRC=@dbSource&DB=@dbName"]
                ]
            },
            {
                id: 5,
                th: "สมุดรายวัน",
                en: "Journal",
                color: "#7c46d8",
                rgb: "124,70,216",
                icon: "menu_book",
                description: "บันทึกและปรับปรุงรายการทางบัญชี",
                steps: [
                    ["menu_book", "สมุดรายวันทั่วไป", "General Journal","accmain/JournalEntries"],
                    ["book_2", "สมุดรายวันรับ", "Receipt Journal","accmain/ReceiveVoucher"],
                    ["book_2", "สมุดรายวันจ่าย", "Payment Journal", "accmain/PaymentVoucher"],
                    ["edit_note", "ปรับปรุงรายการ", "Journal Voucher", "accmobile/AccordionJV?accDoctype=AJ"],
                    ["restart_alt", "กลับรายการ", "Reversing Journal", "accmobile/AccordionJV?accDoctype=JV"]
                ],
                actions: [
                    ["add_box", "สร้างรายการสมุดรายวัน","accmobile/AccordionJV?accDoctype=JV"],
                    ["upload_file", "นำเข้ารายการ", "accmobile"],
                    ["fact_check", "รายวันจ่าย","accmobile/AccordionPV?accDoctype=PV"],
                    ["search", "รายวันรับ","accmobile/AccordionRV?accDoctype=RV"],
                    ["monitoring", "รายงานสมุดรายวัน","accreport/?Form=ReportJournal&Type=&DateFrom=@dateFrom.ToString("yyyy-MM-dd")&DateTo=@dateTo.ToString("yyyy-MM-dd")&SRC=@dbSource&DB=@dbName"]
                ]
            },
            {
                id: 6,
                th: "รายงาน",
                en: "Report",
                color: "#2d6fe2",
                rgb: "45,111,226",
                icon: "pie_chart",
                description: "รายงานบัญชี การเงิน และการวิเคราะห์",
                steps: [
                    ["bar_chart", "รายงานการจ่าย", "Payment Report", "accreport/?Form=ReportPayment&SRC=@dbSource&DB=@dbName"],
                    ["bar_chart", "รายงานการรับ", "Receive Report","accreport/?Form=ReportReceive&SRC=@dbSource&DB=@dbName"],
                    ["donut_large", "บัญชีแยกประเภท", "General Ledger","accreport/?Form=MonthlyBalance_V2&SRC=@dbSource&DB=@dbName"],
                    ["analytics", "รายงานลูกหนี้", "AR Report","accreport/?Form=ReportAR&SRC=@dbSource&DB=@dbName"],
                    ["analytics", "รายงานเจ้าหนี้", "AP Report","accreport/?Form=ReportAP&SRC=@dbSource&DB=@dbName"]
                ],
                actions: [
                    ["bar_chart", "รายงานต่างๆ","accreport/?Form=Report&SRC=@dbSource&DB=@dbName"],
                    ["donut_large", "งบฐานะการเงิน", "accreport/?Form=BalanceSheet&Mode=1&SRC=@dbSource&DB=@dbName"],
                    ["query_stats", "งบทดลอง","accreport/?Form=TrialBalance&SRC=@dbSource&DB=@dbName"],
                    ["analytics", "รายงานอายุลูกหนี้","accreport/?Form=ReportAgingAR&SRC=@dbSource&DB=@dbName"],
                    ["analytics", "รายงานอายุเจ้าหนี้","accreport/?Form=ReportAgingAP&SRC=@dbSource&DB=@dbName"]
                ]
            },
            {
                id: 7,
                th: "แฟ้มข้อมูลหลัก",
                en: "Master Files",
                color: "#687489",
                rgb: "104,116,137",
                icon: "folder",
                description: "จัดการข้อมูลอ้างอิงหลักของระบบ",
                steps: [
                    ["groups", "ข้อมูลกิจการ", "Company", "accmain/CompanyProfile"],
                    ["groups", "มาตรฐานบัญชี", "Config", "accreport/?Form=ConfigAcc&SRC=@dbSource&DB=@dbName"],
                    ["inventory_2", "สินค้า / หน่วยนับ", "Item/Unit", "accmain/ProductTypes"],
                    ["warehouse", "คลังสินค้า", "Warehouse", "accmain/Warehouses"],
                    ["settings", "ตั้งค่าระบบ", "Setting", "accmain/AccConfigs"]
                ],
                actions: [
                    ["person_add", "เพิ่มข้อมูลคู่ค้า", "accmobile/Suppliers"],
                    ["person_add", "เพิ่มข้อมูลลูกค้า", "accmobile/Customers"],
                    ["add_box", "เพิ่มสินค้า","accmobile/ProductList"],
                    ["account_tree", "จัดการผังบัญชี", "accmobile/AccCodes"],
                    ["upload_file", "ข้อมูลเพิ่มเติม", "accmobile/OptionalFieldSchemas"]
                ]
            },
            {
                id: 8,
                th: "AI OCR",
                en: "Intelligent Documents",
                color: "#d83b7d",
                rgb: "216,59,125",
                icon: "memory",
                description: "อ่าน ตรวจสอบ และสร้างรายการจากเอกสารอัตโนมัติ",
                steps: [
                    ["upload_file", "อัปโหลดเอกสาร", "Upload" ,"accmobile"],
                    ["document_scanner", "ประมวลผล OCR", "Read Data", "accmobile"],
                    ["memory", "AI ตรวจสอบอัจฉริยะ", "Smart Validate", "accmobile"],
                    ["rule", "จับคู่ข้อมูล", "Auto Matching", "accmobile"],
                    ["auto_awesome", "สร้างรายการอัตโนมัติ", "Auto Journal", "accmobile"]
                ],
                actions: [
                    ["cloud_upload", "อัปโหลดเอกสาร", "accmobile"],
                    ["pending_actions", "รายการรอประมวลผล","accmobile"],
                    ["fact_check", "ตรวจสอบผลลัพธ์","accmobile"],
                    ["history", "ประวัติเอกสาร", "accmobile"],
                    ["monitoring", "รายงาน AI OCR","accmobile"]
                ]
            }
        ];

        let activeIndex = 0;

        const nav = document.getElementById("moduleNav");
        const panel = document.getElementById("detailPanel");
        const pointer = document.getElementById("activePointer");
        const panelTitle = document.getElementById("panelTitle");
        const panelDescription = document.getElementById("panelDescription");
        const headingIcon = document.getElementById("headingIcon");
        const workflowGrid = document.getElementById("workflowGrid");
        const quickList = document.getElementById("quickList");
        const toast = document.getElementById("toast");

        function setTheme(module) {
            panel.style.setProperty("--accent", module.color);
            panel.style.setProperty("--accent-rgb", module.rgb);
            pointer.style.setProperty("--active-color", module.color);

            document.querySelectorAll(".module-button").forEach((button, index) => {
                button.classList.toggle("active", index === activeIndex);
            });
        }

        function buildNav() {
            nav.innerHTML = modules.map((module, index) => `
                <button
                  class="module-button ${index === activeIndex ? "active" : ""}"
                  style="--accent:${module.color};--accent-rgb:${module.rgb}"
                  data-index="${index}"
                  aria-label="${module.th} ${module.en}"
                >
                  <span class="module-circle">
                    <span class="module-inner">
                      <span class="module-number">${module.id}</span>
                      <span class="module-icon">${module.icon}</span>
                      <span class="module-th">${module.th}</span>
                      <span class="module-en">(${module.en})</span>
                    </span>
                  </span>
                </button>
              `).join("");

            nav.querySelectorAll(".module-button").forEach(button => {
                button.addEventListener("click", () => {
                    activeIndex = Number(button.dataset.index);
                    renderModule(true);
                    button.scrollIntoView({ behavior: "smooth", block: "nearest", inline: "center" });
                });
            });
        }

        function updatePointer() {
            const activeButton = nav.querySelector(".module-button.active");
            if (!activeButton || window.innerWidth <= 1280) return;

            const wrapRect = document.querySelector(".module-nav-wrap").getBoundingClientRect();
            const buttonRect = activeButton.getBoundingClientRect();
            const center = buttonRect.left - wrapRect.left + (buttonRect.width / 2);
            pointer.style.setProperty("--pointer-x", `${center}px`);
        }

        function renderModule(animate = false) {
            const module = modules[activeIndex];

            if (animate) {
                panel.style.animation = "none";
                void panel.offsetWidth;
                panel.style.animation = "";
            }

            setTheme(module);
            panelTitle.textContent = `${module.th} (${module.en})`;
            panelDescription.textContent = module.description;
            headingIcon.textContent = module.icon;

            workflowGrid.style.setProperty("--step-count", module.steps.length);
            workflowGrid.innerHTML = module.steps.map((step, index) => `
                <article class="step-card" data-action="${step[3]}">
                  <span class="step-number">${index + 1}</span>
                  <span class="step-icon">${step[0]}</span>
                  <div class="step-th">${step[1]}</div>
                  <div class="step-en">(${step[2]})</div>
                </article>
              `).join("");

            quickList.innerHTML = module.actions.map(action => `
                <button class="quick-button" type="button" data-action="${action[2]}">
                  <span class="quick-icon">
                    <span class="material-symbols-rounded">${action[0]}</span>
                  </span>
                  <span class="quick-label">${action[1]}</span>
                  <span class="quick-arrow">chevron_right</span>
                </button>
              `).join("");

            quickList.querySelectorAll(".quick-button").forEach(button => {
                button.addEventListener("click", () => {
                    let path = `/${button.dataset.action}`;
                    window.location.href = path;
                });
            });

            workflowGrid.querySelectorAll(".step-card").forEach(button => {
                button.addEventListener("click", () => {
                    let path = `/${button.dataset.action}`;
                    window.location.href = path;
                });
            });

            requestAnimationFrame(updatePointer);
        }

        function showToast(message) {
            toast.textContent = message;
            toast.classList.add("show");
            clearTimeout(showToast.timer);
            showToast.timer = setTimeout(() => toast.classList.remove("show"), 1800);
        }

        window.addEventListener("resize", updatePointer);

        buildNav();
        renderModule();
    </script>
</body>
</html>
