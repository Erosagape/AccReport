@Code
    Layout = Nothing
    ViewData("Title") = "Dashboard"
    Dim dbSource = ViewBag.AccDatabase
    If Not Request.QueryString("SRC") Is Nothing Then
        dbSource = Request.QueryString("SRC")
    End If
    Dim dbname = ViewBag.JobDatabase
    If Not Request.QueryString("DB") Is Nothing Then
        dbname = Request.QueryString("DB").ToString()
    End If
End Code
<!DOCTYPE html>
<html lang="th">
<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>TAWAN Accounting Dashboard</title>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Noto+Sans+Thai:wght@400;500;600;700&display=swap" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/chart.js@4.4.3/dist/chart.umd.min.js"></script>
    <style>
        :root {
            --nav: #071f55;
            --nav2: #0b3b83;
            --blue: #1769d2;
            --blue2: #eaf3ff;
            --ink: #10244d;
            --muted: #687895;
            --line: #dfe7f2;
            --card: #fff;
            --bg: #f4f7fb;
            --green: #0b966b;
            --red: #df3b4c;
            --amber: #e99a12;
            --shadow: 0 10px 28px rgba(23,53,104,.09)
        }

        * {
            box-sizing: border-box
        }

        body {
            margin: 0;
            font-family: 'Noto Sans Thai',Arial,sans-serif;
            background: var(--bg);
            color: var(--ink)
        }

        .app {
            display: grid;
            grid-template-columns: 258px 1fr;
            min-height: 100vh
        }

        .sidebar {
            background: linear-gradient(180deg,var(--nav),#06183f);
            color: #fff;
            padding: 18px 14px;
            position: sticky;
            top: 0;
            height: 100vh;
            overflow: auto
        }

        .brand {
            display: flex;
            align-items: center;
            gap: 10px;
            padding: 3px 5px 20px;
            border-bottom: 1px solid rgba(255,255,255,.14)
        }

            .brand img {
                width: 168px;
                height: 31px;
                object-fit: contain;
                background: #fff;
                border-radius: 3px
            }

            .brand small {
                display: none
            }

        .menu-title {
            font-size: 12px;
            color: #9eb7dd;
            margin: 20px 10px 8px
        }

        .nav-link {
            display: flex;
            align-items: center;
            gap: 11px;
            color: #dce8fb;
            text-decoration: none;
            padding: 11px 12px;
            border-radius: 11px;
            margin: 3px 0;
            font-size: 14px
        }

            .nav-link:hover, .nav-link.active {
                background: linear-gradient(90deg,#1769d2,#2584ed);
                color: #fff
            }

        .ico {
            width: 20px;
            text-align: center
        }

        .agent {
            margin-top: 24px;
            background: rgba(255,255,255,.06);
            border: 1px solid rgba(255,255,255,.13);
            border-radius: 16px;
            padding: 9px
        }

            .agent img {
                width: 100%;
                display: block;
                border-radius: 12px
            }

        main {
            min-width: 0
        }

        .topbar {
            height: 66px;
            background: #fff;
            border-bottom: 1px solid var(--line);
            display: flex;
            align-items: center;
            justify-content: space-between;
            padding: 0 26px;
            position: sticky;
            top: 0;
            z-index: 5
        }

        .crumb {
            font-weight: 700
        }

        .top-actions {
            display: flex;
            gap: 10px;
            align-items: center
        }

        .btn, .select {
            border: 1px solid var(--line);
            background: #fff;
            border-radius: 10px;
            padding: 9px 13px;
            font: inherit;
            color: var(--ink)
        }

        .content {
            padding: 22px 24px 30px;
            max-width: 1720px;
            margin: auto
        }

        .page-head {
            display: flex;
            justify-content: space-between;
            gap: 16px;
            align-items: flex-start;
            margin-bottom: 16px
        }

            .page-head h1 {
                font-size: 25px;
                margin: 0 0 2px
            }

        .sub {
            color: var(--muted);
            font-size: 14px
        }

        .actions {
            display: flex;
            gap: 10px
        }

        .hero {
            background: #fff;
            border: 1px solid var(--line);
            border-radius: 18px;
            overflow: hidden;
            margin-bottom: 16px;
            box-shadow: var(--shadow)
        }

            .hero img {
                display: block;
                width: 100%;
                height: 170px;
                object-fit: cover
            }

        .kpis {
            display: grid;
            grid-template-columns: repeat(6,minmax(150px,1fr));
            gap: 12px
        }

        .card {
            background: var(--card);
            border: 1px solid var(--line);
            border-radius: 16px;
            box-shadow: var(--shadow)
        }

        .kpi {
            padding: 16px
        }

            .kpi .label {
                font-size: 13px;
                color: #5e6f8d
            }

            .kpi .value {
                font-size: 24px;
                font-weight: 700;
                margin: 7px 0
            }

        .trend {
            font-size: 12px;
            color: var(--green)
        }

            .trend.down {
                color: var(--red)
            }

        .grid {
            display: grid;
            grid-template-columns: 1.25fr 1fr .9fr;
            gap: 14px;
            margin-top: 14px
        }

        .panel {
            padding: 16px;
            min-width: 0
        }

            .panel h3 {
                font-size: 16px;
                margin: 0 0 12px
            }

            .panel canvas {
                width: 100% !important;
                height: 250px !important
            }

        .wide {
            grid-column: span 2
        }

        .mini-grid {
            display: grid;
            grid-template-columns: repeat(3,1fr);
            gap: 10px
        }

        .mini {
            padding: 12px;
            border: 1px solid var(--line);
            border-radius: 12px
        }

            .mini b {
                display: block;
                font-size: 18px;
                margin-top: 5px
            }

        .ratio {
            display: flex;
            justify-content: space-between;
            border-top: 1px solid var(--line);
            padding: 9px 0;
            font-size: 13px
        }

            .ratio:first-of-type {
                border-top: 0
            }

        table {
            width: 100%;
            border-collapse: collapse;
            font-size: 13px
        }

        th {
            background: #eef4fd;
            color: #244476;
            text-align: left
        }

        th, td {
            padding: 9px 10px;
            border-bottom: 1px solid var(--line)
        }

            td.num {
                text-align: right
            }

        .alert {
            display: flex;
            justify-content: space-between;
            gap: 10px;
            padding: 11px 0;
            border-bottom: 1px solid var(--line);
            font-size: 13px
        }

            .alert:last-child {
                border: 0
            }

        .badge {
            font-size: 11px;
            border-radius: 999px;
            padding: 4px 8px;
            background: #fff2df;
            color: #a96200
        }

        .danger {
            background: #ffe8eb;
            color: #b91e32
        }

        .ok {
            background: #e8f8f1;
            color: #087452
        }

        footer {
            display: flex;
            justify-content: space-between;
            color: #6d7b94;
            font-size: 12px;
            padding: 20px 3px
        }

        @@media(max-width:1350px) {
            .kpis {
                grid-template-columns: repeat(3,1fr)
            }

            .grid {
                grid-template-columns: 1fr 1fr
            }

            .wide {
                grid-column: span 2
            }
        }

        @@media(max-width:900px) {
            .app {
                grid-template-columns: 76px 1fr
            }

            .sidebar {
                padding: 14px 8px
            }

            .brand img {
                width: 54px;
                object-fit: cover;
                object-position: left
            }

            .nav-link span:not(.ico), .menu-title, .agent {
                display: none
            }

            .nav-link {
                justify-content: center
            }

            .content {
                padding: 16px
            }

            .grid {
                grid-template-columns: 1fr
            }

            .wide {
                grid-column: span 1
            }

            .kpis {
                grid-template-columns: repeat(2,1fr)
            }

            .hero {
                display: none
            }
        }

        @@media(max-width:560px) {
            .kpis {
                grid-template-columns: 1fr
            }

            .page-head {
                display: block
            }

            .actions {
                margin-top: 12px
            }

            .topbar {
                padding: 0 14px
            }

            .top-actions .select {
                display: none
            }

            .mini-grid {
                grid-template-columns: 1fr
            }

            .panel canvas {
                height: 220px !important
            }
        }
    </style>
</head>
<body>
    <div class="app">
        <aside class="sidebar">
            <div class="brand">
                <img src="~/logo-tawan.jpg" alt="TAWAN">
                <small>บริษัท ตะวันเทคโนโลยี จำกัด</small>
            </div>
            <div class="menu-title">เมนูรายงาน</div>
            <a class="nav-link active" href="#"><span class="ico">◉</span><span>Dashboard</span></a>
            <a class="nav-link" href="#"><span class="ico">▤</span><span>รายงานการเงิน</span></a>
            <a class="nav-link" href="#"><span class="ico">▥</span><span>รายงานยอดขาย</span></a>
            <a class="nav-link" href="#"><span class="ico">◫</span><span>รายงานซื้อ/เจ้าหนี้</span></a>
            <a class="nav-link" href="#"><span class="ico">◉</span><span>ลูกหนี้/วางบิล</span></a>
            <a class="nav-link" href="#"><span class="ico">◷</span><span>ค่าใช้จ่ายและต้นทุน</span></a>
            <a class="nav-link" href="#"><span class="ico">▦</span><span>รายงานภาษี</span></a>
            <a class="nav-link" href="#"><span class="ico">▣</span><span>สมุดบัญชีแยกประเภท</span></a>
            <a class="nav-link" href="#"><span class="ico">⚖</span><span>งบทดลอง</span></a>
            <a class="nav-link" href="#"><span class="ico">▧</span><span>งบกำไรขาดทุน</span></a>
            <a class="nav-link" href="#"><span class="ico">▰</span><span>งบดุล</span></a>
            <a class="nav-link" href="#"><span class="ico">↝</span><span>กระแสเงินสด</span></a>
            <a class="nav-link" href="#"><span class="ico">⌁</span><span>วิเคราะห์ทางการเงิน</span></a>
            <a class="nav-link" href="#"><span class="ico">✓</span><span>ตรวจสอบภายใน</span></a>
            <div class="agent">
                <img src="~/ai-agent.svg" alt="AI Agent">
            </div>
        </aside>
        <main>
            <header class="topbar">
                <div class="crumb">☰ &nbsp; รายงานทางบัญชี › Dashboard</div>
                <div class="top-actions">
                    <select class="select"><option>ส.ค. 2569</option></select>
                    <button class="btn">🔔</button>
                    <button class="btn">TEST ▾</button>
                </div>
            </header>
            <div class="content">
                <div class="page-head">
                    <div>
                        <h1>รายงานทางบัญชี (Accounting Dashboard)</h1>
                        <div class="sub">ภาพรวมผลการดำเนินงานทางการเงิน กำไร ขาดทุน ต้นทุน และรายงานตรวจสอบบัญชี</div>
                    </div>
                    <div class="actions">
                        <button class="btn" onclick="location.reload()">↻ รีเฟรช</button>
                        <button class="btn" onclick="window.print()">⇩ Export / Print</button>
                    </div>
                </div>
                <section class="hero">
                    <img src="~/finance-hero.svg" alt="Financial analytics">
                </section>
                <section class="kpis">
                    <div class="card kpi">
                        <div class="label">ยอดขายรวม</div>
                        <div class="value">922,880.00</div>
                        <div class="trend">▲ 12.6% จากเดือนที่แล้ว</div>
                    </div>
                    <div class="card kpi">
                        <div class="label">ยอดซื้อรวม</div>
                        <div class="value">74,016.68</div>
                        <div class="trend down">▼ 5.3% จากเดือนที่แล้ว</div>
                    </div>
                    <div class="card kpi">
                        <div class="label">รายได้รวม</div>
                        <div class="value">167,346.50</div>
                        <div class="trend">▲ 9.8% จากเดือนที่แล้ว</div>
                    </div>
                    <div class="card kpi">
                        <div class="label">ค่าใช้จ่ายรวม</div>
                        <div class="value">196,173.10</div>
                        <div class="trend down">▲ 7.2% จากเดือนที่แล้ว</div>
                    </div>
                    <div class="card kpi">
                        <div class="label">กำไรสุทธิ</div>
                        <div class="value">31,713.26</div>
                        <div class="trend">▲ 18.4% จากเดือนที่แล้ว</div>
                    </div>
                    <div class="card kpi">
                        <div class="label">เงินสดและเงินฝาก</div>
                        <div class="value">4,777,791.50</div>
                        <div class="trend">▲ 3.6% จากเดือนที่แล้ว</div>
                    </div>
                </section>
                <section class="grid">
                    <div class="card panel wide">
                        <h3>แนวโน้มรายได้ ค่าใช้จ่าย และกำไรสุทธิ</h3>
                        <canvas id="trendChart"></canvas>
                    </div>
                    <div class="card panel">
                        <h3>โครงสร้างรายได้</h3>
                        <canvas id="revenueChart"></canvas>
                    </div>
                    <div class="card panel">
                        <h3>ฐานะการเงิน</h3>
                        <div class="mini-grid">
                            <div class="mini">
                                สินทรัพย์รวม
                                <b>8,952,330.45</b>
                                <span class="trend">▲ 4.67%</span>
                            </div>
                            <div class="mini">
                                หนี้สินรวม
                                <b>3,284,538.20</b>
                                <span class="trend down">▲ 2.19%</span>
                            </div>
                            <div class="mini">
                                ส่วนของผู้ถือหุ้น
                                <b>5,667,792.25</b>
                                <span class="trend">▲ 6.21%</span>
                            </div>
                        </div>
                        <h3 style="margin-top:17px">อัตราส่วนทางการเงิน</h3>
                        <div class="ratio">
                            <span>Gross Profit Margin</span>
                            <b>26.45%</b>
                        </div>
                        <div class="ratio">
                            <span>Net Profit Margin</span>
                            <b>18.95%</b>
                        </div>
                        <div class="ratio">
                            <span>Current Ratio</span>
                            <b>2.45 เท่า</b>
                        </div>
                        <div class="ratio">
                            <span>D/E Ratio</span>
                            <b>0.58 เท่า</b>
                        </div>
                    </div>
                    <div class="card panel">
                        <h3>กระแสเงินสด</h3>
                        <canvas id="cashChart"></canvas>
                    </div>
                    <div class="card panel">
                        <h3>วิเคราะห์กำไรขั้นต้น</h3>
                        <canvas id="profitChart"></canvas>
                        <div class="mini-grid">
                            <div class="mini">
                                รายได้รวม
                                <b>167,346.50</b>
                            </div>
                            <div class="mini">
                                ต้นทุนขาย
                                <b>62,473.26</b>
                            </div>
                            <div class="mini">
                                กำไรขั้นต้น
                                <b>104,873.24</b>
                            </div>
                        </div>
                    </div>
                    <div class="card panel">
                        <h3>ลูกหนี้คงเหลือ (AR Aging)</h3>
                        <table>
                            <thead>
                                <tr>
                                    <th>ช่วงอายุ</th>
                                    <th class="num">จำนวนเงิน</th>
                                    <th class="num">%</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>ยังไม่ถึงกำหนด</td>
                                    <td class="num">2,145,600.00</td>
                                    <td class="num">46.85</td>
                                </tr>
                                <tr>
                                    <td>1–30 วัน</td>
                                    <td class="num">1,286,450.00</td>
                                    <td class="num">28.07</td>
                                </tr>
                                <tr>
                                    <td>31–60 วัน</td>
                                    <td class="num">732,120.00</td>
                                    <td class="num">15.97</td>
                                </tr>
                                <tr>
                                    <td>61–90 วัน</td>
                                    <td class="num">276,800.00</td>
                                    <td class="num">6.04</td>
                                </tr>
                                <tr>
                                    <td>เกิน 90 วัน</td>
                                    <td class="num">139,620.00</td>
                                    <td class="num">3.07</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class="card panel">
                        <h3>เจ้าหนี้คงค้าง (AP Aging)</h3>
                        <table>
                            <thead>
                                <tr>
                                    <th>ช่วงอายุ</th>
                                    <th class="num">จำนวนเงิน</th>
                                    <th class="num">%</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>ยังไม่ถึงกำหนด</td>
                                    <td class="num">1,245,300.00</td>
                                    <td class="num">45.12</td>
                                </tr>
                                <tr>
                                    <td>1–30 วัน</td>
                                    <td class="num">954,810.00</td>
                                    <td class="num">34.61</td>
                                </tr>
                                <tr>
                                    <td>31–60 วัน</td>
                                    <td class="num">358,600.00</td>
                                    <td class="num">12.98</td>
                                </tr>
                                <tr>
                                    <td>61–90 วัน</td>
                                    <td class="num">136,420.00</td>
                                    <td class="num">4.95</td>
                                </tr>
                                <tr>
                                    <td>เกิน 90 วัน</td>
                                    <td class="num">67,408.20</td>
                                    <td class="num">2.44</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <div class="card panel">
                        <h3>รายการแจ้งเตือน</h3>
                        <div class="alert">
                            <span>ลูกหนี้เกินกำหนด 90 วัน 5 รายการ</span>
                            <span class="badge danger">139,620.00</span>
                        </div>
                        <div class="alert">
                            <span>เช็คค้างรับใกล้ครบกำหนด 3 รายการ</span>
                            <span class="badge">85,450.00</span>
                        </div>
                        <div class="alert">
                            <span>ใบหัก ณ ที่จ่ายใกล้ครบกำหนด</span>
                            <span class="badge">ภายใน 7 วัน</span>
                        </div>
                        <div class="alert">
                            <span>ค่าใช้จ่ายเกินงบประมาณ</span>
                            <span class="badge danger">12.5%</span>
                        </div>
                        <div class="alert">
                            <span>รายการกระทบยอดครบถ้วน</span>
                            <span class="badge ok">ปกติ</span>
                        </div>
                    </div>
                </section>
                <footer>
                    <span>© 2026 TAWAN TECHNOLOGY CO., LTD.</span>
                    <span>Smart Accounting System • AI Analytics</span>
                </footer>
            </div>
        </main>
    </div>
    <script>
        const gridColor = '#e6edf6', textColor = '#60708c';
        Chart.defaults.font.family = 'Noto Sans Thai';
        Chart.defaults.color = textColor;
        new Chart(
            document.getElementById('trendChart'),
            {
                type: 'bar',
                data: {
                    labels: ['มี.ค.', 'เม.ย.', 'พ.ค.', 'มิ.ย.', 'ก.ค.', 'ส.ค.'],
                    datasets: [
                        {
                            label: 'รายได้รวม',
                            data: [410000, 505000, 620000, 684000, 772000, 922880],
                            backgroundColor: '#2572dc', borderRadius: 7
                        },
                        {
                            label: 'ค่าใช้จ่าย',
                            data: [205000, 173000, 154000, 229000, 168000, 196173],
                            type: 'line', borderColor: '#e04a37', backgroundColor: '#e04a37', tension: .35
                        },
                        {
                            label: 'กำไรสุทธิ',
                            data: [62000, 73000, 88000, 96000, 112000, 131713],
                            type: 'line', borderColor: '#0b966b', backgroundColor: '#0b966b', tension: .35
                        }]
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false,
                    plugins: {
                        legend: { position: 'top' }
                    },
                    scales: {
                        x: {
                            grid: { display: false }
                        },
                        y: {
                            grid: { color: gridColor }
                        }
                    }
                }
            });
        new Chart(
            document.getElementById('revenueChart'),
            {
                type: 'doughnut',
                data: {
                    labels: ['ค่าบริการ SRV', 'ค่าขนส่ง', 'ต่างประเทศ DN', 'เบ็ดเตล็ด'],
                    datasets: [
                        {
                            data: [58.5, 24.1, 10.3, 7.1],
                            backgroundColor: ['#2674db', '#16a087', '#ff9f1c', '#ffd166'], borderWidth: 0
                        }]
                }, options: {
                    responsive: true, maintainAspectRatio: false, cutout: '68%',
                    plugins: {
                        legend: { position: 'bottom' }
                    }
                }
            });
        new Chart(document.getElementById('cashChart'),
            {
                type: 'bar', data: {
                    labels: ['ดำเนินงาน', 'ลงทุน', 'จัดหาเงิน', 'เงินสดสุทธิ'],
                    datasets: [
                        {
                            label: 'กระแสเงินสด',
                            data: [385210, -125400, -63120, 196690],
                            backgroundColor: ['#3aae70', '#2878dc', '#ffbd35', '#3aae70'], borderRadius: 7
                        }]
                },
                options: {
                    responsive: true, maintainAspectRatio: false,
                    plugins: {
                        legend: { display: false }
                    },
                    scales: {
                        x: { grid: { display: false } },
                        y: { grid: { color: gridColor } }
                    }
                }
            });
        new Chart(document.getElementById('profitChart'),
            {
                type: 'doughnut',
                data: {
                    labels: ['กำไรขั้นต้น', 'ต้นทุนขาย'],
                    datasets: [{
                        data: [62.74, 37.26],
                        backgroundColor: ['#196ad3', '#b9dfc8'], borderWidth: 0
                    }]
                },
                options: {
                    responsive: true, maintainAspectRatio: false, cutout: '76%',
                    plugins: {
                        legend: { position: 'bottom' },
                        tooltip: {
                            callbacks: { label: c => c.label + ': ' + c.raw + '%' }
                        }
                    }
                }
            });
    </script>
</body>
</html>
