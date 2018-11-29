<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Templates/Templante.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Proyecto.web.vistas.Usuarios.Usuarios" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container media">
        <div class="card mx-auto mt-5">
          <div class="card-header"><h3><b>Informacion de Usuarios</b></h3></div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblCorreo" Text="Email"></asp:Label>
                            <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweCorreo" runat="server" TargetControlID="txtCorreo" WatermarkText="Correo" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lblPassword" Text="Password"></asp:Label>
                            <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbwePassword" runat="server" TargetControlID="txtPassword" WatermarkText="Password" />
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
                <h3><label class="badge badge-primary">Todos los Usuarios</label></h3>
                <asp:GridView Width="100%" runat="server" OnRowCommand="gvwUsuarios_RowCommand" EmptyDataText="No se encontraron registros" AutoGenerateColumns="False" ID="gvwUsuarios" BackColor="Turquoise" BorderColor="black" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black">
                    <Columns>
                        <asp:TemplateField HeaderText="Codigo">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblCodigo" Text='<%# Bind("inId") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Email">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblCorreo" Text='<%# Bind("stLogin") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Contraceña">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblContraceña" Text='<%# Bind("stPassword") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ID Perfil">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblID_Perfil" Text='<%# Bind("obClsPerfiles.inId") %>'></asp:Label>
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
                  </div>
             </div>
        </div>
</asp:Content>

