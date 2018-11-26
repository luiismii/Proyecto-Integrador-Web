<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Templates/Templante.Master" AutoEventWireup="true" CodeBehind="TipoPago.aspx.cs" Inherits="Proyecto.web.vistas.TipoPago.TipoPago" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container media">
        <div class="card mx-auto mt-5">
            <div class="card-header"><b>Informacion de Tipo de Pago</b></div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <asp:Label runat="server" ID="lblId_TipoPago" Text="Id_TipoPago"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlId_TipoPago" CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                </div>


                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <asp:Label runat="server" ID="lblDescripcion" Text="Descripcion"></asp:Label>
                            <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweDescripcion" runat="server" TargetControlID="txtDescripcion" WatermarkText="Descripcion" />
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

