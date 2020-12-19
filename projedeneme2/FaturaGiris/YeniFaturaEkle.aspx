<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YeniFaturaEkle.aspx.cs" Inherits="projedeneme2.YeniFaturaEkle.YeniFaturaEkleWebForm" %>

<!DOCTYPE html>
<html>

<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
	<title>Table - 5M Macro</title>
	<meta name="description" content="In this software project we will make a project process tracking system for companies. The &quot;tracking&quot; means in this project is:

⦁	Progress for work 
⦁	Paying fees to various clients
⦁	Work done by company employees

A company uses this software will easily track their process by using features of this software mentioned above.">
	<link rel="stylesheet" href="../assets/bootstrap/css/bootstrap.min.css">
	<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i">
	<link rel="stylesheet" href="../assets/fonts/fontawesome-all.min.css">
	<link rel="stylesheet" href="../assets/fonts/font-awesome.min.css">
	<link rel="stylesheet" href="../assets/fonts/fontawesome5-overrides.min.css">
    <style type="text/css">
        .auto-style1 {
            height: 28px;
        }
        .auto-style2 {
            position: relative;
            width: 100%;
            flex-basis: 0;
            flex-grow: 1;
            max-width: 100%;
            height: 100%;
            left: 0px;
            top: 0px;
            padding-left: .75rem;
            padding-right: .75rem;
        }
        .auto-style3 {
            width: 20%;
            height: 28px;
        }
    </style>
</head>

<body id="page-top">
	<form runat="server">
	<div id="wrapper">
		<nav class="navbar navbar-dark align-items-start sidebar sidebar-dark accordion bg-gradient-primary p-0" style="color: rgb(0,85,164);background: rgb(49,115,163);min-width: auto;max-width: 250;">
			<div class="container-fluid d-flex flex-column p-0">
				<a class="navbar-brand d-flex justify-content-center align-items-center sidebar-brand m-0" href="#">
					<div class="sidebar-brand-icon rotate-n-15"><i class="fas fa-marker"></i></div>
					<div class="sidebar-brand-text mx-3"><span>5M Macro</span></div>
				</a>
				<hr class="sidebar-divider my-0">
				<ul class="nav navbar-nav text-light" id="accordionSidebar">
					<li class="nav-item text-left">
						<h4 class="text-left d-md-flex justify-content-md-start align-items-md-start" style="margin-left: 7%;margin-bottom: 0;margin-top: 0.4em;">Main</h4>
					</li>
					<li class="nav-item"><asp:LinkButton class="nav-link" runat="server" OnClick="Homepage_click" style="padding: auto;padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fas fa-tachometer-alt" style="width: 1.5em;"></i><span>Ana Sayfa</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" runat="server" OnClick="User_Profile_click" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fas fa-user" style="width: 1.5em;height: 1em;"></i><span>Profilim</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" runat="server" OnClick="Login_click" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="far fa-user-circle" style="width: 1.5em;"></i><span>Giriş</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" runat="server" OnClick="Register_click" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fas fa-user-circle" style="width: 1.5em;"></i><span>Kayıt ol</span></asp:LinkButton></li>
					<li class="nav-item" style="padding: 0.4em;">
						<h4 class="text-left" style="margin-left: 7%;margin-bottom: 0;margin-top: 0.4em;">Tanım</h4>
					</li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Proje_Tanim_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-envelope-o" style="width: 1.5em;"></i><span>Proje Tanım</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Cari_Kart_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"> <i class="fas fa-table" style="width: 1.5em;"></i><span>Cari Kart</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Doviz_Kur_Tanim_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="far fa-money-bill-alt" style="width: 1.5em;height: 1em;"></i><span>Döviz Kur Tanımı</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Masraf_Tanimi_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="far fa-money-bill-alt" style="width: 1.5em;height: 1em;"></i><span>Masraf Tanımı</span></asp:LinkButton></li>
					<li class="nav-item">
						<h4 class="text-left" style="margin-left: 7%;margin-top: 0.4em;margin-bottom: 0;">Giriş</h4>
					</li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Fatura_Giris_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Fatura Giriş</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Proje_Odeme_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Proje Ödeme</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Fatura_Odeme_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Fatura Ödeme</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Masraf_Odeme_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Masraf Ödeme</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Cek_Giris_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Çek Giriş / Çek Ödeme</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Kasa_Giris_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Kasa Giriş</span></asp:LinkButton></li>
					<li class="nav-item">
						<h4 class="text-left" style="margin-left: 7%;margin-top: 0.4em;margin-bottom: 0;">Raporlar</h4>
					</li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Tedarikci_Borc_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Tedarikçi Borç / Ödeme Takip</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Müsteri_Alacak_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Müşteri Alacak / Ödeme Listesi</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Bakiye_Durumu_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Bakiye Durumu</span></asp:LinkButton></li>
					<li class="nav-item">
						<h4 class="text-left" style="margin-left: 0.7em;margin-top: 0.4em;margin-bottom: 0;">Servis</h4>
					</li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Kod_Degistir_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Kod Değiştir</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Urun_Ara_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Ürün Ara</span></asp:LinkButton></li>
					<li class="nav-item"><asp:LinkButton class="nav-link" OnClick="Hata_Tespit_click" runat="server" style="padding-top: 0.4em;padding-bottom: 0.4em;"><i class="fa fa-star" style="width: 1.5em;"></i><span>Hata Tespit</span></asp:LinkButton></li>
				</ul><a href="#"></a>
				<div class="text-center d-none d-md-inline"><button class="btn rounded-circle border-0" id="sidebarToggle" type="button"></button></div><a href="register.html"></a></div>
		</nav>
		<div class="d-flex flex-column" id="content-wrapper">
			<div id="content">
				<nav class="navbar navbar-light navbar-expand bg-white shadow mb-4 topbar static-top">
					<div class="container-fluid"><button class="btn btn-link d-md-none rounded-circle mr-3" id="sidebarToggleTop" type="button"><i class="fas fa-bars"></i></button>
						<form class="form-inline d-none d-sm-inline-block mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search">
							<div class="input-group"><input class="bg-light form-control border-0 small" type="text" placeholder="Search for ...">
								<div class="input-group-append"><button class="btn btn-primary py-0" type="button"><i class="fas fa-search"></i></button></div>
							</div>
						</form>
						<ul class="nav navbar-nav flex-nowrap ml-auto">
							<li class="nav-item dropdown d-sm-none no-arrow"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#"><i class="fas fa-search"></i></a>
								<div class="dropdown-menu dropdown-menu-right p-3 animated--grow-in" aria-labelledby="searchDropdown">
									<form class="form-inline mr-auto navbar-search w-100">
										<div class="input-group"><input class="bg-light form-control border-0 small" type="text" placeholder="Search for ...">
											<div class="input-group-append"><button class="btn btn-primary py-0" type="button"><i class="fas fa-search"></i></button></div>
										</div>
									</form>
								</div>
							</li>
							<li class="nav-item dropdown no-arrow mx-1">
								<div class="nav-item dropdown no-arrow"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#"><span class="badge badge-danger badge-counter">3+</span><i class="fas fa-bell fa-fw"></i></a>
									<div class="dropdown-menu dropdown-menu-right dropdown-list dropdown-menu-right animated--grow-in">
										<h6 class="dropdown-header">alerts center</h6>
										<a class="d-flex align-items-center dropdown-item" href="#">
											<div class="mr-3">
												<div class="bg-primary icon-circle"><i class="fas fa-file-alt text-white"></i></div>
											</div>
											<div><span class="small text-gray-500">December 12, 2019</span>
												<p>A new monthly report is ready to download!</p>
											</div>
										</a>
										<a class="d-flex align-items-center dropdown-item" href="#">
											<div class="mr-3">
												<div class="bg-success icon-circle"><i class="fas fa-donate text-white"></i></div>
											</div>
											<div><span class="small text-gray-500">December 7, 2019</span>
												<p>$290.29 has been deposited into your account!</p>
											</div>
										</a>
										<a class="d-flex align-items-center dropdown-item" href="#">
											<div class="mr-3">
												<div class="bg-warning icon-circle"><i class="fas fa-exclamation-triangle text-white"></i></div>
											</div>
											<div><span class="small text-gray-500">December 2, 2019</span>
												<p>Spending Alert: We've noticed unusually high spending for your account.</p>
											</div>
										</a><a class="text-center dropdown-item small text-gray-500" href="#">Show All Alerts</a></div>
								</div>
							</li>
							<li class="nav-item dropdown no-arrow mx-1">
								<div class="nav-item dropdown no-arrow"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#"><i class="fas fa-envelope fa-fw"></i><span class="badge badge-danger badge-counter">7</span></a>
									<div class="dropdown-menu dropdown-menu-right dropdown-list dropdown-menu-right animated--grow-in">
										<h6 class="dropdown-header">alerts center</h6>
										<a class="d-flex align-items-center dropdown-item" href="#">
											<div class="dropdown-list-image mr-3"><img class="rounded-circle" src="assets/img/avatars/avatar4.jpeg">
												<div class="bg-success status-indicator"></div>
											</div>
											<div class="font-weight-bold">
												<div class="text-truncate"><span>Hi there! I am wondering if you can help me with a problem I've been having.</span></div>
												<p class="small text-gray-500 mb-0">Emily Fowler - 58m</p>
											</div>
										</a>
										<a class="d-flex align-items-center dropdown-item" href="#">
											<div class="dropdown-list-image mr-3"><img class="rounded-circle" src="assets/img/avatars/avatar2.jpeg">
												<div class="status-indicator"></div>
											</div>
											<div class="font-weight-bold">
												<div class="text-truncate"><span>I have the photos that you ordered last month!</span></div>
												<p class="small text-gray-500 mb-0">Jae Chun - 1d</p>
											</div>
										</a>
										<a class="d-flex align-items-center dropdown-item" href="#">
											<div class="dropdown-list-image mr-3"><img class="rounded-circle" src="assets/img/avatars/avatar3.jpeg">
												<div class="bg-warning status-indicator"></div>
											</div>
											<div class="font-weight-bold">
												<div class="text-truncate"><span>Last month's report looks great, I am very happy with the progress so far, keep up the good work!</span></div>
												<p class="small text-gray-500 mb-0">Morgan Alvarez - 2d</p>
											</div>
										</a>
										<a class="d-flex align-items-center dropdown-item" href="#">
											<div class="dropdown-list-image mr-3"><img class="rounded-circle" src="assets/img/avatars/avatar5.jpeg">
												<div class="bg-success status-indicator"></div>
											</div>
											<div class="font-weight-bold">
												<div class="text-truncate"><span>Am I a good boy? The reason I ask is because someone told me that people say this to all dogs, even if they aren't good...</span></div>
												<p class="small text-gray-500 mb-0">Chicken the Dog · 2w</p>
											</div>
										</a><a class="text-center dropdown-item small text-gray-500" href="#">Show All Alerts</a></div>
								</div>
								<div class="shadow dropdown-list dropdown-menu dropdown-menu-right" aria-labelledby="alertsDropdown"></div>
							</li>
							<div class="d-none d-sm-block topbar-divider"></div>
							<li class="nav-item dropdown no-arrow">
								<div class="nav-item dropdown no-arrow"><a class="dropdown-toggle nav-link" data-toggle="dropdown" aria-expanded="false" href="#"><span class="d-none d-lg-inline mr-2 text-gray-600 small">Valerie Luna</span><img class="border rounded-circle img-profile" src="assets/img/avatars/avatar1.jpeg"></a>
									<div
										class="dropdown-menu shadow dropdown-menu-right animated--grow-in"><a class="dropdown-item" href="#"><i class="fas fa-user fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Profile</a><a class="dropdown-item" href="#"><i class="fas fa-cogs fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Settings</a>
										<a
											class="dropdown-item" href="#"><i class="fas fa-list fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Activity log</a>
											<div class="dropdown-divider"></div><a class="dropdown-item" href="#"><i class="fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400"></i>&nbsp;Logout</a></div>
					</div>
					</li>
					</ul>
			</div>
			</nav>
			<div class="container-fluid">
				<h3 class="text-dark mb-4">Fatura Giriş</h3>
				<div class="card shadow">
					<div class="card-header py-3"><span>Yeni Fatura Ekle</span></div>
					<div class="card-body">
						<div class="row" style="height: 100%;">
							<div class="col">
								<div class="card" style="height: 97%;">
									<div class="card-body">
										<h4 class="card-title">Temel Bilgiler</h4>
										<div class="table-responsive">
											<table class="table">
												<thead>
													<tr></tr>
												</thead>
												<tbody>
													<tr>
														<td style="width: 20%;">Fatura Numarası<br></td>
														<td><asp:TextBox runat="server" id="InvoiceNumber" style="padding: 0px;min-width: 100%;" placeholder="Invoice Number"></asp:TextBox></td>
													</tr>
													<tr>
														<td>Fatura Tarihi<br></td>
														<td><asp:TextBox runat="server" id="InvoiceDate" type="date" name="InvoiceDate"></asp:TextBox></td>
													</tr>
													<tr>
														<td>Cari Kodu<br></td>
														<td><asp:TextBox runat="server" id="entityCode" style="padding: 0px;min-width: 100%;" placeholder="Entity Code"></asp:TextBox></td>
													</tr>
													<tr>
														<td>Açıklama<br></td>
														<td><asp:TextBox runat="server" id="InvoiceDescription" style="padding: 0px;min-width: 100%;" placeholder="Description"></asp:TextBox></td>
													</tr>
													<tr>
														<td>Vade Tarihi<br></td>
														<td><asp:TextBox runat="server" id="PaymentDate" type="date" name="PaymentDate"></asp:TextBox></td>
													</tr>
													<tr>
														<td>Döviz Kodu<br></td>
														<td><select id="CurrencyCode" name="CurrencyCode">
																<optgroup label="Döviz Kodu">
																	<option value="TRY" selected="">TRY</option>
																	<option value="USD">USD</option>
																	<option value="EUR">EUR</option>
																</optgroup>
														    </select></td>
													</tr>
												</tbody>
											</table>
										</div>
									</div>
								</div>
							</div>
							<div class="col">
								<div class="card" style="height: 97%;">
									<div class="card-body">
										<h4 class="card-title">Tutar Bilgileri</h4>
										<div class="table-responsive">
											<table class="table">
												<thead>
													<tr></tr>
												</thead>
												<tbody>
													<tr>
														<td style="width: 20%;">Tutar</td>
														<td><asp:TextBox runat="server" type="number" id="InvoiceAmount" placeholder="Amount" ReadOnly="true"></asp:TextBox></td>
													</tr>
													<tr>
														<td>KDV miktarı</td>
														<td><asp:TextBox runat="server" type="number" id="InvoiceKDVamount" min="0" step="0.1" placeholder="KDV amount" ReadOnly="true"></asp:TextBox></td>
													</tr>
													<tr>
														<td>Toplam Tutar</td>
														<td><asp:TextBox runat="server" type="number" id="InvoiceTotalAmount" placeholder="Total Amount" ReadOnly="true"></asp:TextBox></td>
													</tr>
													<tr></tr>
													<tr></tr>
												</tbody>
											</table>
										</div>
									</div>
								</div>
							</div>
						</div>
					<div class="table-responsive table mt-2" id="dataTable-1" role="grid" aria-describedby="dataTable_info">
                                <table class="table my-0" id="DetailTable">
                                    <thead>
                                        <tr>
                                            <th>Yeni Ekle</th>
                                            <th>Tip (Masraf/Proje)</th>
                                            <th>Proje/Masraf Kodu</th>
                                            <th>Stok Türü</th>
                                            <th>Stok Kodu</th>
                                            <th>Stok Adı</th>
                                            <th>Birim</th>
                                            <th>Miktarı</th>
                                            <th>Tutar</th>
                                            <th>KDV Oranı</th>
                                            <th>KDV miktarı</th>
                                            <th>Toplam Tutar</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr></tr>
                                        <tr id ="Content1">
                                            <td id="ButtonCell1"><asp:LinkButton ID="NewContentBtn" runat="server" OnClientClick="{return false;}"><span><i class="fa fa-plus"></i></span></asp:LinkButton></td>
                                            <td><select id="Type">
                                                    <optgroup label="Tip">
                                                        <option value="Masraf" selected="">Masraf</option>
                                                        <option value="Proje">Proje</option>
                                                    </optgroup>
                                                </select></td>
                                            <td><input class="form-control-sm" type="text" id="ProjectExpenseCode" placeholder="Project / Expense Code">
												<asp:Button runat="server" class="btn btn-primary btn-sm" data-toggle="modal" data-target="#ProjectCodeModal" Text="..." OnClientClick ="return false" /><br>
                                                <div class="modal fade" role="dialog" tabindex="-1" id="ProjectCodeModal">
                                                    <div class="modal-dialog" role="document">
                                                        <div class="modal-content">
                                                            <div class="modal-header">
                                                                <h4 class="modal-title">Modal Title</h4><button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                                                            </div>
                                                            <div class="modal-body">
                                                                <p>The content of your modal.</p>
                                                            </div>
                                                            <div class="modal-footer"><button class="btn btn-light" type="button" data-dismiss="modal">Close</button><button class="btn btn-primary" type="button">Save</button></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td><select id="StockKind">
                                                    <optgroup label="Stok Türü">
                                                        <option value="Mekanik" selected="">Mekanik</option>
                                                        <option value="Pinomatik">Pinomatik</option>
                                                        <option value="Otomasyon">Otomasyon</option>
                                                    </optgroup>
                                                </select></td>
                                            <td><asp:Textbox runat="server" id="StockCode" placeholder="Stock Code"></asp:Textbox></td>
                                            <td><asp:Textbox runat="server" id="StockName" placeholder="Stock Name"></asp:Textbox></td>
                                            <td><select id="Unit">
                                                    <optgroup label="Birim">
                                                        <option value="Adet" selected="">Adet</option>
                                                        <option value="Kilogram">Kilogram</option>
                                                        <option value="Metre">Metre</option>
                                                    </optgroup>
                                                </select></td>
                                            <td><asp:Textbox runat="server" type="number" id="Count" placeholder="Count" min="0" step="1"></asp:Textbox></td>
                                            <td><asp:Textbox runat="server" type="number" id="Amount" placeholder="Amount" min="0"></asp:Textbox></td>
                                            <td><select id="KDVpercentage">
                                                    <optgroup label="KDV oranı">
                                                        <option value="0" selected="">0</option>
                                                        <option value="1">1</option>
                                                        <option value="8">8</option>
                                                        <option value="18">18</option>
                                                    </optgroup>
                                                </select></td>
                                            <td><asp:Textbox runat="server" type="number" id="KDVamount" placeholder="KDV amount" ReadOnly="true"></asp:Textbox></td>
                                            <td><asp:Textbox runat="server" type="number" id="TotalAmount" placeholder="Total Amount" ReadOnly="true"></asp:Textbox></td>
                                        </tr>
                                        <tr></tr>
                                    </tbody>
                                    <tfoot>
                                        <tr>
                                            <td><strong>Yeni Ekle</strong><br></td>
                                            <td><strong>Tip (Masraf/Proje)</strong><br></td>
                                            <td><strong>Proje Kodu</strong><br></td>
                                            <td><strong>Stok Türü</strong><br></td>
                                            <td><strong>Stok Kodu</strong><br></td>
                                            <td><strong>Stok Adı</strong><br></td>
                                            <td><strong>Birim</strong><br></td>
                                            <td><strong>Miktarı</strong><br></td>
                                            <td><strong>Tutar</strong><br></td>
                                            <td><strong>KDV Oranı</strong><br></td>
                                            <td><strong>KDV miktarı</strong><br></td>
                                            <td><strong>Toplam Tutar</strong><br></td>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div><asp:LinkButton runat="server" OnClick="AddNewInvoice_Click" class="btn btn-primary" id="AddInvoice" style="float: right;background: rgb(49,115,163);margin-top: 2%;">Yeni Fatura Ekle</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
		<footer class="bg-white sticky-footer">
			<div class="container my-auto">
				<div class="text-center my-auto copyright"><span>Copyright © 5M Macro 2020</span></div>
			</div>
		</footer>
	</div><a class="border rounded d-inline scroll-to-top" href="#page-top"><i class="fas fa-angle-up"></i></a></div>
	<script src="assets/js/jquery.min.js"></script>
	<script src="assets/bootstrap/js/bootstrap.min.js"></script>
	<script src="assets/js/chart.min.js"></script>
	<script src="assets/js/bs-init.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.4.1/jquery.easing.js"></script>
	<script src="assets/js/theme.js"></script>
	<script src="../Scripts/NewInvoiceContent.js"></script>
	</form>
</body>

</html>