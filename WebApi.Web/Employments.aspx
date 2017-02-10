<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employments.aspx.cs" Inherits="WebApi.Web.Employments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                Id
            <input type="text" name="name" id="txtid" value="" />
                <input type="button" id="btngetEmployments" onclick="getdata()" name="name" value="GetEmployee" />
            </div>
            <div id="MyDiv">
            </div>
        </div>
    </form>

    <form id="myform" method="post" action="http://localhost:58796/PostData">
        <table>
            <tr>
                <td> EmpoymentId   </td>
                <td>
                    <input type="text" name="EmpoymentId" value="" />
                </td>
            </tr>
            <tr>
                <td> FirstName   </td>
                <td>
                    <input type="text" name="FirstName" value="" />
                </td>
            </tr>
            <tr>
                <td> LastName   </td>
                <td>
                    <input type="text" name="LastName" value="" />
                </td>
            </tr>
            <tr>
                <td> Salary   </td>
                <td>
                    <input type="text" name="Salary" value="" />
                </td>
            </tr>
             <tr>
                <td> Address   </td>
                <td>
                    <input type="text" name="Address" value="" />
                </td>
            </tr>
             <tr>
                <td> PhoneNo   </td>
                <td>
                    <input type="text" name="PhoneNo" value="" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <input type="submit" name="name" onclick="PostData();" value="Save Data" />
                    
                    
                </td>
            </tr>
        </table>

    </form>
    <div><input type="submit" name="name" onclick="deletedata();" value="Delete Data" />
</div>
    <script src="Scripts/jquery-3.1.0.min.js"></script>
    <script>
        $(document).ready(function () {
            $.getJSON("http://localhost:58796/api/Employments", function (data) {
                var table = "<table><tr><td>EmploymentId</td><td>FirstName</td><td>LastName</td><td>Salary</td><td>Address</td><td>PhoneNo</td></tr>";
                for (var i = 0; i < data.length; i++) {
                    table = table + "<tr><td>" + data[i].EmploymentId + "</td><td>" + data[i].FirstName + "</td><td>" + data[i].LastName + "</td><td>" + data[i].Salary + "</td><td>" + data[i].Address + "</td><td>" + data[i].PhoneNo + "</td></tr>";
                }
                table = table + "</table>";
                $("#MyDiv").html(table);
            });
        });
        function getdata() {
            //debugger;
            //JAVASCRIPT 
            var id = document.getElementById("txtid").value;
            var url = "http://localhost:58796/api/Employments?id=" + id;
            // debugger
            $.getJSON(url,
            function (data) {
                //debugger
                var table = "<table border='2'><tr><td>EmploymentId</td><td>FirstName</td><td>LastName</td><td>Salary</td><td>Address</td><td>PhoneNo</td></tr>";
                table = table + "<tr><td>" + data.EmploymentId + "</td><td>" + data.FirstName + "</td><td>" + data.LastName + "</td><td>" + data.Salary + "</td><td>" + data.Address + "</td><td>" + data.PhoneNo + "</td></tr>";
                table = table + "</table>";
                $("#MyDiv").html(table);
            });
        }

        function deletedata() {
            //debugger;
            //JAVASCRIPT 
            var id = document.getElementById("txtid").value;
            var url = "http://localhost:58796/DeleteData?id=" + id;
            // debugger
            $.getJSON(url,
            function (data) {
                alert(data);
                //debugger
                //var table = "<table border='2'><tr><td>EmploymentId</td><td>FirstName</td><td>LastName</td><td>Salary</td><td>Address</td><td>PhoneNo</td></tr>";
                //table = table + "<tr><td>" + data.EmploymentId + "</td><td>" + data.FirstName + "</td><td>" + data.LastName + "</td><td>" + data.Salary + "</td><td>" + data.Address + "</td><td>" + data.PhoneNo + "</td></tr>";
                //table = table + "</table>";
                //$("#MyDiv").html(table);
            });
        }

        function PostData() {
            //debugger;
            $.post("http://localhost:58796/PostData", $("#myform").serialize(), function (msg) {
                alert(msg);
            });
        }
    </script>

</body>
</html>







<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="Cb.Inc.Web1.Users" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            Id
            <input type="text" name="name" id="txtid" value="" />
            <input type="button" id="btngetuser" onclick="getdata()" name="name" value="GetUser" />
        </div>
        <div id="MyDiv">
        </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script>
        $(document).ready(function () {
            $.getJSON("http://localhost:64473/api/Users", function (data) {
                var table = "<table><tr><td>UserId</td><td>User Name</td><td>Password </td></tr>";
                for (var i = 0; i < data.length; i++) {
                    table = table + "<tr><td>" + data[i].UserId + "</td><td>" + data[i].UserName + "</td><td>" + data[i].Password + "</td></tr>";
                }
                table = table + "</table>";
                $("#MyDiv").html(table);
            });
        });
        function getdata() {
            //debugger;
            //JAVASCRIPT 
            var id = document.getElementById("txtid").value;
            var url = "http://localhost:64473/api/Users?id=" + id;
            // debugger
            $.getJSON(url,
            function (data) {
                //debugger
                var table = "<table border='1'><tr><td>UserId</td><td>User Name</td><td>Password</td></tr>";
                table = table + "<tr><td>" + data.UserId + "</td><td>" + data.UserName + "</td><td>" + data.Password + "</td></tr>";
                table = table + "</table>";
                $("#MyDiv").html(table);
            });
        }
    </script>
</body>
</html>--%>
