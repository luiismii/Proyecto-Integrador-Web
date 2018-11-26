<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Templates/Templante.Master" AutoEventWireup="true" CodeBehind="Promociones.aspx.cs" Inherits="Proyecto.web.vistas.Promociones.Promociones" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container media">
        <div class="card mx-auto mt-5">
            <div class="card-header"><b>Informacion de Promociones</b></div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblId_Promociones" Text="Id_Promociones"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlId_Promociones" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblFecha_Hasta" Text="Fecha Hasta">
                                <asp:TextBox runat="server" ID="txtFecha_Hasta" CssClass="form-control"></asp:TextBox>
                                <ajaxToolkit:TextBoxWatermarkExtender ID="tbweFecha_Hasta" runat="server" TargetControlID="txtFecha_Hasta" WatermarkText="Fecha Hasta" />
                                <ajaxToolkit:CalendarExtender ID="ceFecha_Hasta" runat="server" TargetControlID="txtFecha_Hasta" Format="dd-MM-yyyy" />
                            </asp:Label>
                        </div>
                    </div>
                </div>


                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblDescuento" Text="Descuento"></asp:Label>
                            <asp:TextBox runat="server" ID="txtDescuento" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweDescuento" runat="server" TargetControlID="txtDescuento" WatermarkText="Descuento" />
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

