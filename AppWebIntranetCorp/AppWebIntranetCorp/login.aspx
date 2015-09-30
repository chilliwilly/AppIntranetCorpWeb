<%@ Page Language="C#" Title="Intranet Corporativa" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AppWebIntranetCorp.login" %>

<%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">--%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<script type="text/javascript" src="//code.jquery.com/jquery-1.10.2.js"></script>         
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">--%>
    <script type="text/javascript" src="plugins/jQuery/jQuery-2.1.4.min.js"></script>
    <script type="text/javascript" src="bootstrap/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">
</head>
<body>
    <div class="container">
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <input type="image" src="img/fondo_claro_transparente.png" style="text-align: center; width: 250px; height: 68px;" />
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Acceso Intranet Corporativa</div>
                    <div style="float: right; font-size: 80%; position: relative; top: -10px"><a href="mailto:wcontreras@dts.cl?subject=Problema Sistema Cotizacion Web">Problemas con Contraseña?</a></div>
                </div>

                <div style="padding-top: 30px" class="panel-body">
                    <div style="display: none" id="login-alert" class="alert alert-danger col-sm-12"></div>

                    <form id="form1" runat="server" class="form-horizontal" role="form">
                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <input id="inputEmail" type="text" class="form-control" name="username" value="" placeholder="Nombre de Usuario" required readonly/>
                        </div>

                        <div style="margin-bottom: 25px" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <input id="inputPasswd" type="password" class="form-control" name="password" placeholder="Contraseña" required autofocus />
                        </div>

                        <div style="margin-top: 10px" class="form-group">
                            <!-- Button -->
                            <div class="col-sm-12 controls">
                                <asp:Button ID="btnEntrar" runat="server" Text="Entrar"  CssClass="btn btn-success" OnClick="btnEntrar_Click" />
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-md-12 control">
                                <div style="border-top: 1px solid#888; padding-top: 15px; font-size: 85%">
                                    Cualquier problema con el acceso, contactar con el administrador
                                    <a href="mailto:wcontreras@dts.cl?subject=Problema Sistema Cotizacion Web">aqui!.
                                    </a>
                                </div>
                            </div>
                        </div>
                    </form>

                </div>
            </div>
        </div>
    </div>
</body>
</html>