<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Templates/Templante.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Proyecto.web.vistas.Ventas.Ventas" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />

    <div class="container">
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <h1>Carro de compra</h1>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <label class="badge badge-dark">Proveedores</label>
                    <asp:DropDownList runat="server" ID="ddlProveedor" CssClass="form-control"></asp:DropDownList>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Button runat="server" ID="btnConsultar" Text="Consultar" OnClick="btnConsultar_Click" CssClass="btn btn-primary btn-lg" />
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-6">
                    <label class="badge badge-dark">Productos</label>
                    <asp:GridView Width="100%" runat="server" EmptyDataText="No hay Productos" AutoGenerateColumns="False" ID="gvwProductos" OnRowCommand="gvwProductos_RowCommand" BackColor="Cyan" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black">
                        <Columns>
                            <asp:TemplateField HeaderText="Codigo">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblCodigo" Text='<%# Bind("obClsProductos.inId_Producto") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nombre">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblNombre" Text='<%# Bind("obClsProductos.stNombre_Producto") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Precio">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblPrecio" Text='<%# Bind("inValor") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Cantidad">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblCantidad" Text='<%# Bind("inCantidad") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:ImageButton runat="server" ID="ibAgregar"
                                        ImageUrl="~/Recursos/Imagenes/agregar.jpg" Height="30px" Width="30px"
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
                <div class="col-md-6">
                    <label class="badge badge-dark">Productos Agregados</label>
                    <asp:GridView runat="server" Width="100%" EmptyDataText="No Hay Productos Agregados" AutoGenerateColumns="False" ID="gvwProductosAgregados" OnRowCommand="gvwProductosAgregados_RowCommand" BackColor="PeachPuff" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" >
                        <Columns>
                            <asp:TemplateField HeaderText="Codigo">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblCodigo" Text='<%# Bind("obClsProductos.inId_Producto") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nombre">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblNombre" Text='<%# Bind("obClsProductos.stNombre_Producto") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Precio">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblPrecio" Text='<%# Bind("inValor") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Cantidad">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblCantidad" Text='<%# Bind("inCantidad") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:ImageButton runat="server" ID="ibEliminar"
                                        ImageUrl="~/Recursos/Imagenes/27748043-eliminar-botón-quitar.jpg" Height="30px" Width="30px"
                                        CommandName="Eliminar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>"></asp:ImageButton>
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
                    <asp:Button runat="server" ID="btnConfirmarCompra" Text="Confirmar Compra" CssClass="btn btn-success btn-lg" />
                    <asp:Button runat="server" ID="btnCancelarCompra" Text="Cancelar Compra" CssClass="btn btn-danger btn-lg" OnClick="btnCancelarCompra_Click" />

                </div>
            </div>
        </div>
    </div>

</asp:Content>
