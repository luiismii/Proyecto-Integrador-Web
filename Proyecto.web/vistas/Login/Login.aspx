<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto.web.vistas.Login.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <title>Login</title>

    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />

    <!-- Custom fonts for this template-->
    <link href="../../vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css" />

    <!-- Custom styles for this template-->
    <link href="css/sb-admin.css" rel="stylesheet" />
    <!-- Bootstrap core JavaScript-->
    <script src=".././vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" />
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
</head>
<body class="bg-dark">
    <form runat="server">
        <div class="container media">
            <div class="card mx-auto mt-5">
                <div class="card-header"><b>Iniciar Sesion</b></div>
                <div class="card-body">
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label runat="server" ID="lblEmail" Text="Usuario"></asp:Label>
                                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" placeholder="Usuario"></asp:TextBox>
                            </div>
                            <div class="col-md-12">
                                <div class="form-label-group">
                                    <asp:Label runat="server" ID="lblPassword" Text="Password"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" placeholder="Password"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="checkbox">
                            <label class="form-checkbox-label" />
                            <asp:CheckBox ID="chkRecordar" runat="server" Text="Recordar Usuario" />
                        </div>
                    </div>
                    <asp:Button ID="btnAceptars" runat="server" CssClass="btn btn-primary btn-block" Text="Iniciar Sesion" OnClick="btnAceptar_Click" href="../Index/Index.aspx" />

                    <div class="text-center">
                        <a class="d-block small mt-3" href="../Registrar/Registro.aspx">Crear Una Cuenta</a>
                        <a class="d-block small" href="../Password/OlvidoPassword.aspx">Olvido Su Contraceña?</a>
                    </div>
                      </div>
                  </div>
              </div>
    </form>
</body>
</html>
