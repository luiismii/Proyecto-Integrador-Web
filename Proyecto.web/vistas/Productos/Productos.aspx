﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Templates/Templante.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Proyecto.web.vistas.Productos.Productos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container media">
        <div class="card mx-auto mt-5">
    <div class="card-header"><h3><b>Informacion de Productos</b></h3></div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblNombre_Productos" Text="Nombre Producto"></asp:Label>
                            <asp:TextBox runat="server" ID="txtNombre_Productos" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweNombre_Productos" runat="server" TargetControlID="txtNombre_Productos" WatermarkText="Nombre Producto" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblPrecio" Text="Precio">
                                <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control"></asp:TextBox>
                                <ajaxToolkit:TextBoxWatermarkExtender ID="tbwePrecio" runat="server" TargetControlID="txtPrecio" WatermarkText="Precio" />
                            </asp:Label>
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
                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-success btn-lg" OnClick="btnGuardar_Click" />
                    <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-danger btn-lg" />
                </div>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="form-row">
            <div class="col-md-12">
                <h3><label class="badge badge-primary">Todos los Productos</label></h3>
                <asp:GridView Width="100%" runat="server" OnRowCommand="gvwProductos_RowCommand" EmptyDataText="No se encontraron registros" AutoGenerateColumns="false" ID="gvwProductos"  BackColor="Turquoise" BorderColor="black" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black">
                    <Columns>
                        <asp:TemplateField HeaderText="Codigo">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblCodigo" Text='<%# Bind("inId_Producto") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Nombre Producto">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblNombre" Text='<%# Bind("stNombre_Producto") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Descripcion">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblDescripcion" Text='<%# Bind("stDescripcion") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Precio">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblPrecio" Text='<%# Bind("inPrecio") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:ImageButton runat="server" ID="ibEditar"
                                    ImageUrl="~/Recursos/Imagenes/edit.png" Height="20px" Width="20px"
                                    CommandName="Editar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>"></asp:ImageButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:ImageButton runat="server" ID="ibEliminar"
                                    ImageUrl="~/Recursos/Imagenes/remove.png" Height="20px" Width="20px"
                                    CommandName="Eliminar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" ></asp:ImageButton>
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
