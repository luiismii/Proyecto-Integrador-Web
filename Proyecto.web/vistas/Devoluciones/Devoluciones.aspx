<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Templates/Templante.Master" AutoEventWireup="true" CodeBehind="Devoluciones.aspx.cs" Inherits="Proyecto.web.vistas.Devoluciones.Devoluciones" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container media">
        <div class="card mx-auto mt-5">
            <div class="card-header"><h3><b>Informacion de Devoluciones</b></h3></div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblId_Devoluciones" Text="Id_Devoluciones"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlDevoluciones"  Enabled="false" CssClass="form-control"></asp:DropDownList>
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
                                <asp:Label runat="server" ID="lblId_Factura" Text="Id_Factura"></asp:Label>
                                <asp:DropDownList runat="server" ID="ddlId_Factura" CssClass="form-control"></asp:DropDownList>
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
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblCambio" Text="Cambio"></asp:Label>
                            <asp:TextBox runat="server" ID="txtCambio" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweCambio" runat="server" TargetControlID="txtCambio" WatermarkText="Cambio" />
                        </div>
                    </div>
                </div>


                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <asp:Label runat="server" ID="lblObservacion" Text="Observacion"></asp:Label>
                            <asp:TextBox runat="server" ID="txtObservacion" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweObservacion" runat="server" TargetControlID="txtObservacion" WatermarkText="Observacion" />
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-success btn-lg" />
                    <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-danger btn-lg" />
                </div>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="form-row">
            <div class="col-md-12">
                <h3>
                    <label class="badge badge-primary">Todas las Devoluciones</label></h3>
                <asp:GridView Width="100%" runat="server" EmptyDataText="No se encontraron registros" AutoGenerateColumns="False" ID="gvwDevoluciones" BackColor="Turquoise" BorderColor="black" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black">
                    <Columns>
                        <asp:TemplateField HeaderText="Codigo">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblCodigo" Text='<%# Bind("inId_Devoluciones") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cantidad">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblCantidad" Text='<%# Bind("inCantidad") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fecha">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblFecha" Text='<%# Bind("stFecha") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cambio">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblCambio" Text='<%# Bind("stCambio") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Codigo Factura">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblId_Factura" Text='<%# Bind("obClsFacturas") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Obsevacion">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblObsevacion" Text='<%# Bind("stObservacio") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Codigo Producto">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblId_Productos" Text='<%# Bind("obClsProductos") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>                        
                         <asp:TemplateField>
                            <ItemTemplate>
                                <asp:ImageButton runat="server" ID="ibEditar"
                                    ImageUrl="~/Recursos/Imagenes/edit.png" Height="20px" Width="20px"
                                    CommandName="Agregar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>"></asp:ImageButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:ImageButton runat="server" ID="ibEliminar"
                                    ImageUrl="~/Recursos/Imagenes/remove.png" Height="20px" Width="20px"
                                    CommandName="Agregar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>"></asp:ImageButton>
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
