<%@ Page Title="" Language="C#" MasterPageFile="~/Recursos/Templates/Templante.Master" AutoEventWireup="true" CodeBehind="Proveedores.aspx.cs" Inherits="Proyecto.web.vistas.Proveedores.Proveedores" %>

<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container media">
        <div class="card mx-auto mt-5">
            <div class="card-header">
                <h3><b>Informacion de Proveedores</b></h3>
            </div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-3">
                            <asp:Label runat="server" ID="lblPrimer_Nombre" Text="Primer_Nombre"></asp:Label>
                            <asp:TextBox runat="server" ID="txtPrimer_Nombre" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbwePrimer_Nombre" runat="server" TargetControlID="txtPrimer_Nombre" WatermarkText="Primer Nombre" />
                        </div>
                        <div class="col-md-3">
                            <asp:Label runat="server" ID="lblSegundo_Nombre" Text="Segundo Nombre"></asp:Label>
                            <asp:TextBox runat="server" ID="txtSegundo_Nombre" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweSegundo_Nombre" runat="server" TargetControlID="txtSegundo_Nombre" WatermarkText="Segundo Nombre" />
                        </div>
                        <div class="col-md-3">
                            <asp:Label runat="server" ID="lblPrimer_Apellido" Text="Primer Apellido"></asp:Label>
                            <asp:TextBox runat="server" ID="txtPrimer_Apellido" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbwePrimer_Apellido" runat="server" TargetControlID="txtPrimer_Apellido" WatermarkText="Primer Apellido" />
                        </div>
                        <div class="col-md-3">
                            <asp:Label runat="server" ID="lblSegundo_Apellido" Text="Segundo Apellido"></asp:Label>
                            <asp:TextBox runat="server" ID="txtSegundo_Apellido" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweSegundo_Apellido" runat="server" TargetControlID="txtSegundo_Apellido" WatermarkText="Segundo Apellido" />
                        </div>
                    </div>
                </div>


                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-3">
                            <asp:Label runat="server" ID="lblEmpresa" Text="Empresa"></asp:Label>
                            <asp:TextBox runat="server" ID="txtEmpresa" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweEmpresa" runat="server" TargetControlID="txtEmpresa" WatermarkText="Empresa" />
                        </div>
                        <div class="col-md-3">
                            <asp:Label runat="server" ID="lblDireccion" Text="Direccion"></asp:Label>
                            <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweDireccion" runat="server" TargetControlID="txtDireccion" WatermarkText=" Direccion" />
                        </div>
                        <div class="col-md-3">
                            <asp:Label runat="server" ID="lblTelefono" Text="Telefono"></asp:Label>
                            <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweTelefono" runat="server" TargetControlID="txtTelefono" WatermarkText="Telefono" />
                        </div>
                        <div class="col-md-3">
                            <asp:Label runat="server" ID="lblCorreo" Text="Correo"></asp:Label>
                            <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbweCorreo" runat="server" TargetControlID="txtCorreo" WatermarkText=" Correo" />
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-3">
                            <asp:Label runat="server" ID="lblFecha" Text="Fecha">
                                <asp:TextBox runat="server" ID="txtFecha" CssClass="form-control"></asp:TextBox>
                                <ajaxToolkit:TextBoxWatermarkExtender ID="tbweFecha" runat="server" TargetControlID="txtFecha" WatermarkText="Fecha" />
                                <ajaxToolkit:CalendarExtender ID="ceFecha" runat="server" TargetControlID="txtFecha" Format="dd-MM-yyyy" />
                            </asp:Label>
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
                    <label class="badge badge-primary">Todos los Proveedores</label></h3>
                <asp:GridView Width="100%" runat="server" EmptyDataText="No se encontraron registros" AutoGenerateColumns="False" ID="gvwProveedores"  BackColor="Turquoise" BorderColor="black" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black">
                    <Columns>
                        <asp:TemplateField HeaderText="Codigo">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblCodigo" Text='<%# Bind("inId_Proveedores") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Primer Nombre">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblstPrimer_Nombre" Text='<%# Bind("stPrimer_Nombre") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Segundo Nombre">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblSegundo_Nombre" Text='<%# Bind("stSegundo_Nombre") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Primer Apellido">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblPrimer_Apellido" Text='<%# Bind("stPrimer_Apellido") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Segundo Apellido">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblSegundo_Apellido" Text='<%# Bind("stSegundo_Apellido") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Empresa">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblEmpresa" Text='<%# Bind("stEmpresa") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Direccion">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblDireccion" Text='<%# Bind("stDireccion") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Telefono">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblTelefono" Text='<%# Bind("stTelefono") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Correo">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblstCorreo" Text='<%# Bind("stCorreo") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fecha Nacimiento">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblFecha_Nacimiento" Text='<%# Bind("stFecha_Nacimiento") %>'></asp:Label>
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
