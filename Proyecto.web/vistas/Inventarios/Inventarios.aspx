<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Templates/Templante.Master" AutoEventWireup="true" CodeBehind="Inventarios.aspx.cs" Inherits="Proyecto.web.vistas.Inventarios.Inventarios" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container media">
        <div class="card mx-auto mt-5">
            <div class="card-header"><b>Informacion de Inventarios</b></div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblId_Inventario" Text="Id_Inventario"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlId_Inventario" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblId_Producto" Text="Id_Producto"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlId_Producto" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                </div>


                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <div class="form-label-group">
                                <asp:Label runat="server" ID="lblId_Proveedores" Text="Id_Proveedores"></asp:Label>
                                <asp:DropDownList runat="server" ID="ddlId_Proveedores" CssClass="form-control"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblFecha" Text="Fecha">
                                <asp:TextBox runat="server" ID="txtFecha" CssClass="form-control"></asp:TextBox>
                                <ajaxToolkit:TextBoxWatermarkExtender ID="tbweFecha" runat="server" TargetControlID="txtFecha" WatermarkText="Fecha" />
                                <ajaxToolkit:CalendarExtender ID="ceFecha" runat="server" TargetControlID="txtFecha" Format="dd-MM-yyyy" />
                            </asp:Label>
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

