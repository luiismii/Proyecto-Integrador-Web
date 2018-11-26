<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Templates/Templante.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="Proyecto.web.vistas.PosiblesClientes.PosiblesClientes" %>

<asp:Content ID="ContentHeader" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <div class="mx auto mt-5">
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <h3>
                        <b>Posibles Clientes</b>

                        <asp:Label runat="server" ID="lblOpcion"></asp:Label>
                    </h3>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblId_Cliente" Text="Cedula" />
                    <asp:TextBox runat="server" ID="txtId_Cliente" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblPrimerNombre" Text="Primer Nombre" />
                    <asp:TextBox runat="server" ID="txtPrimerNombre" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblSegundoNombre" Text="Segundo Nombre" />
                    <asp:TextBox runat="server" ID="txtSegundoNombre" CssClass="form-control"> </asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="form-row">
            <div class="col-md-3">
                <asp:Label runat="server" ID="lblPrimerApellido" Text="Primer Apellido" />
                <asp:TextBox runat="server" ID="txtPrimerApellido" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" ID="lblSegundoApellido" Text="Segundo Apellido" />
                <asp:TextBox runat="server" ID="txtSegundoApellido" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" ID="lblDireccion" Text="Direccion" />
                <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="form-row">
            <div class="col-md-3">
                <asp:Label runat="server" ID="lblTelefono" Text="Telefono" />
                <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" ID="lblCorreo" Text="Correo"></asp:Label>
                <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:Label runat="server" ID="lblFecha_Nacimiento" Text="Fecha Nacimiento" />
                <asp:TextBox runat="server" ID="txtFecha_Nacimiento" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="form-row">
            <div class="col-md-12">
                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-primary" />
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="form-row">
            <div class="col-md-12">
                <h3>
                    <b>Resultados</b>
                </h3>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="form-row">
            <div class="col-md-12" style="overflow: auto">
                <asp:GridView runat="server" ID="gvwDatos" Width="100%" AutoGenerateColumns="False" EmptyDataText="No Se Encontraron Registros" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:TemplateField HeaderText="Id_Cliente">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblId_Cliente" Text='<%# Bind("Id_Cliente") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="Primer Nombre" DataField="Primer_Nombre" />
                        <asp:BoundField HeaderText="Segundo Nombre" DataField="Segundo_Nombre" />
                        <asp:BoundField HeaderText="PrimerApellido" DataField="Primer_Apellido" />
                        <asp:BoundField HeaderText="Segundo Apellido" DataField="Segundo_Apellido" />
                        <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                        <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
                        <asp:BoundField HeaderText="Correo" DataField="Correo" />
                        <asp:BoundField HeaderText="Fecha Nacimiento" DataField="Fecha_Nacimiento" />
                        <asp:TemplateField HeaderText="Editar">
                            <ItemTemplate>
                                <asp:ImageButton ID="ibEditar" runat="server" ImageUrl="~/Recursos/Imagenes/edit.png" Height="20px" Width="20px"
                                    CommandName="Editar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Eliminar">
                            <ItemTemplate>
                                <asp:ImageButton ID="ibEliminar" runat="server" ImageUrl="~/Recursos/Imagenes/remove.png" Height="20px" Width="20px"
                                    CommandName="Eliminar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" />
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>

                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>
