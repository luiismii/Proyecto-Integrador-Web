<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Templates/Templante.Master" AutoEventWireup="true" CodeBehind="Facturas.aspx.cs" Inherits="Proyecto.web.vistas.Facturas.Facturas" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container media">
        <div class="card mx-auto mt-5">
            <div class="card-header"><b>Informacion de Facturas</b></div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblId_Factura" Text="Id_Factura"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlId_Factura" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblId_Ventas" Text="Id_Ventas"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlId_Ventas" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                </div>


                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <div class="form-label-group">
                                <asp:Label runat="server" ID="lblId_Producto" Text="Id_Producto"></asp:Label>
                                <asp:DropDownList runat="server" ID="ddlId_Producto" CssClass="form-control"></asp:DropDownList>
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
                            <asp:Label runat="server" ID="lblDireccion" Text="Direccion"></asp:Label>
                            <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweDireccion" runat="server" TargetControlID="txtDireccion" WatermarkText="Direccion" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblRazon_Social" Text="Razon Social"></asp:Label>
                            <asp:TextBox runat="server" ID="txtRazon_Social" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweRazon_Social" runat="server" TargetControlID="txtRazon_Social" WatermarkText="Razon Social" />
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
