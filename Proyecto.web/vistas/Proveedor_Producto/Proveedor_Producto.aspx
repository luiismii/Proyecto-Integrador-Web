<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Templates/Templante.Master" AutoEventWireup="true" CodeBehind="Proveedor_Producto.aspx.cs" Inherits="Proyecto.web.vistas.Proveedor_Producto.Proveedor_Producto" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container media">
        <div class="card mx-auto mt-5">
            <div class="card-header"><b>Informacion de Proveedor Producto</b></div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblId_Producto" Text="Id_Producto"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlId_Producto" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblId_Proveedor" Text="Id_Proveedor"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlId_Proveedor" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                </div>


                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblCantidad" Text="Cantidad"></asp:Label>
                            <asp:TextBox runat="server" ID="txtCantidad" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweCantidad" runat="server" TargetControlID="txtCantidad" WatermarkText="Cantidad" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblValor" Text="Valor"></asp:Label>
                            <asp:TextBox runat="server" ID="txtValor" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweValor" runat="server" TargetControlID="txtValor" WatermarkText="Valor" />
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="form-row">
                        <a class="btn btn-primary btn-block" href="#">Crear</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

