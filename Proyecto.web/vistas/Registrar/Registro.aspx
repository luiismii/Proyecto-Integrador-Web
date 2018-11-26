<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Proyecto.web.vistas.Registrar.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Registro</title>
    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom fonts for this template-->
    <link href="../../vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom styles for this template-->
    <link href="css/sb-admin.css" rel="stylesheet" />
    <!-- Bootstrap core JavaScript-->
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" />
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>

</head>

<body class="bg-dark">
    <form runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container media">
            <div class="card mx-auto mt-5">
                <div class="card-header"><b>Crear Cuenta</b></div>
                <div class="card-body">
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="lblPrimerNombre" Text="Primer Nombre"></asp:Label>
                                <asp:TextBox runat="server" ID="txtPrimerNombre" CssClass="form-control" placeholder="Primer Nombre"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <div class="form-label-group">
                                    <asp:Label runat="server" ID="lblSegundoNombre" Text="Segundo Nombre"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtSegundoNombre" CssClass="form-control" placeholder="Segundo Nombre"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="lblPrimerApellido" Text="Primer Apellido"></asp:Label>
                                <asp:TextBox runat="server" ID="txtPrimerApellido" CssClass="form-control" placeholder="Primer Apellido"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <div class="form-label-group">
                                    <asp:Label runat="server" ID="lblSegundoApellido" Text="Segundo Apellido"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtSegundoApellido" CssClass="form-control" placeholder="Segundo Apellido"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="lblDireccion" Text="Direccion"></asp:Label>
                                <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" placeholder="Direccion"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="lblTelefono" Text="Telefono"></asp:Label>
                                <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" placeholder="Telefono"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="lblCedula" Text="Cedula"></asp:Label>
                                <asp:TextBox runat="server" ID="txtCedula" CssClass="form-control" placeholder="Cedula"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="lblFechaNacimiento" Text="Fecha Nacimiento"></asp:Label>
                                <asp:TextBox runat="server" ID="txtFechaNacimiento" CssClass="form-control"></asp:TextBox>
                                <ajaxToolkit:TextBoxWatermarkExtender ID="tbweFechaNacimiento" runat="server" TargetControlID="txtFechaNacimiento" WatermarkText="Fecha Nacimiento" />
                                <ajaxToolkit:CalendarExtender ID="ceFechaNacimiento" runat="server" TargetControlID="txtFechaNacimiento" Format="dd-MM-yyyy" />
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="lblCorreo" Text="Correo Electronico"></asp:Label>
                                <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control" placeholder="Correo Electronico"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="lblImagen" Text="Subir Imagen"></asp:Label>
                                <asp:FileUpload runat="server" ID="FuImagen" CssClass="form-control" placeholder="Subir Imagen"></asp:FileUpload>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="lblContraceña" Text="Contraceña"></asp:Label>
                                <asp:TextBox runat="server" ID="txtContraceña" TextMode="Password" CssClass="form-control" placeholder="Contraceña"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <asp:Label runat="server" ID="lblConfirmarContraceña" Text="Confirmar Contraceña"></asp:Label>
                                <asp:TextBox runat="server" ID="txtConfirmarContraceña" TextMode="Password" CssClass="form-control" placeholder="Confirmar Contraceña"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <asp:Button runat="server" ID="btnAceptar" CssClass="btn btn-primary btn-block" Text="Registrar" OnClick="btnCrear_Click" />
                            <div class="col-md-12">
                                <div class="text-center">
                                    <a class="d-block small mt-3" href="../Login/Login.aspx">Login Page</a>
                                    <a class="d-block small" href="../Password/OlvidoPassword.aspx">Olvido Su Contraceña?</a>
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
