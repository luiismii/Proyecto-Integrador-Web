<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OlvidoPassword.aspx.cs" Inherits="Proyecto.web.vistas.Password.OlvidoPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Recuperar Password</title>
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom styles for this template-->
    <link href="css/sb-admin.css" rel="stylesheet" />
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
</head>
<body class="bg-dark">
    <form runat="server">
        <div class="container media">
            <div class="card mx-auto mt-5">
                <div class="card-header"><b>Restaurar Contraceña</b></div>
                <div class="card-body">
                    <div class="text-center mb-4">
                        <h4>Recuperar Contraceña?</h4>
                        <p>Ingrese su dirección de correo electrónico y le enviaremos instrucciones sobre cómo restablecer su contraseña.</p>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-12">
                                <asp:Label runat="server" ID="lblCorreo" Text="Correo Electronico"></asp:Label>
                                <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control" placeholder="Introducir la dirección de correo electrónico"></asp:TextBox>

                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <asp:Button runat="server" ID="btnAceptar" CssClass="btn btn-primary btn-block" Text="Recuperar password" OnClick="btnAceptar_Click" />
                            <div class="col-md-12">
                                <div class="text-center">
                                    <a class="d-block small mt-3" href="../Login/Login.aspx">Login Page</a>
                                    <a class="d-block small" href="../Registrar/Registro.aspx">Registrar?</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
