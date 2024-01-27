<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleCalculator.aspx.cs" Inherits="Simple_calculator.SimpleCalculator" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Desktop Calculator</title>
    <style>
        .calculator 
        {
  border-radius: 10px;
  box-shadow: 0px 3px 6px 0px rgba(0, 0, 0, 0.15), 0px 2px 4px 0px rgba(0, 0, 0, 0.12);
  margin-inline-start: auto;
  margin-inline-end: auto;
  margin-block-start: 2em;
  max-inline-size: 22rem;
  overflow: hidden;
        }
.calculator__output 
{
    width:100%;
   
  background: hsl(202, 11%, 29%);
  color: hsl(255, 100%, 100%);
  font-size:5rem;
  padding-block-start: 0.5rem;
  padding-block-end: 0.5rem;
  padding-inline-end: 0.75rem;
  text-align:right;
  background-color:hsl(255, 100%, 100%);
  color: #fff;
  
}
.calculator__keys {
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  grid-gap: 1px;
  background: hsl(207, 19%, 61%);
}
.calculator__key {
  background: hsl(210, 25%, 95%);
  border: none;
  padding-block-start: 1rem;
  padding-block-end: 1rem;
  padding-inline-end: 1.25rem;
  padding-inline-start: 1.25rem;
  font-size: 1.5rem;
  height:60px;
}
.calculator__key:active,
.calculator__key:focus {
  box-shadow: 0 0 8px 0 rgba(0, 0, 0, 0.3) inset;
  outline: none;
}
.calculator__key--operator {
  background: hsl(208, 25%, 86%);
 
 
}
.calculator__key--operator:active {
  background: hsl(208, 24%, 80%);
}
.calculator__key--enter {
  background-color: #2e86c0;
  border-color: #337cac;
  color: #fff;
  height: 100%;
  width:15px;
  grid-area: 3 / 4 / 6 / 5;
  background: hsl(357, 100%, 72%);
  display: grid;
  grid-template-columns: repeat(4, 1fr);
 
}
.calculator__key--enter
{
   background-color: #4e9ed4;

}

    </style>

</head>
<body>
    <form id="form1" runat="server">
              <div class="calculator">
            <div class="calculator_output">

                <asp:TextBox ID="txtDisplay1" runat="server" ReadOnly="true" CssClass="auto-style3" Width="349px" OnTextChanged="txtDisplay1_TextChanged"  Height="43px" style="text-align: right; font-size:small; " BorderColor="White" BorderStyle="None" ForeColor="#999999"  ></asp:TextBox>
                <asp:TextBox ID="txtDisplay2" onkeypress="return event.charCode >= 48 && event.charCode <= 57" runat="server"  ReadOnly="false" CssClass="auto-style3" Width="349px" OnTextChanged="txtDisplay2_TextChanged" Height="43px" style="text-align: right; font-size:medium" BorderColor="White" BorderStyle="None"   ForeColor="Black" AutoCompleteType="Disabled"  ></asp:TextBox>
            </div>
             <div class="calculator__keys">
                  <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="+"  class="calculator__key calculator__key--operator"/>
                  <asp:Button ID="Button6" runat="server"  OnClick="Button6_Click" Text="-"  class="calculator__key calculator__key--operator"/>
                  <asp:Button ID="Button7" runat="server"  OnClick="Button7_Click1" Text="*" class="calculator__key calculator__key--operator"/>
                  <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="/" class="calculator__key calculator__key--operator"/>

                  <asp:Button ID="Button2" runat="server" Text="7" OnClick="Button2_Click1" class="calculator__key"/>
                  <asp:Button ID="Button3" runat="server" Text="8" OnClick="Button3_Click1" class="calculator__key"/>
                  <asp:Button ID="Button4" runat="server" Text="9" OnClick="Button4_Click1" class="calculator__key"/>
                  <asp:Button ID="Button5" runat="server" Text="BC" OnClick="Button5_Click1" class="calculator__key calculator__key--operator"/>

                  <asp:Button ID="Button9" runat="server" Text="4" OnClick="Button9_Click" class="calculator__key"/>
                  <asp:Button ID="Button10" runat="server" Text="5" OnClick="Button10_Click" class="calculator__key"/>
                  <asp:Button ID="Button11" runat="server" Text="6" OnClick="Button11_Click" class="calculator__key"/>
              
                   <asp:Button ID="Button12" runat="server" Text="1" OnClick="Button12_Click" class="calculator__key"/>
                   <asp:Button ID="Button13" runat="server" Text="2" OnClick="Button13_Click1" class="calculator__key"/>
                   <asp:Button ID="Button14" runat="server" Text="3" OnClick="Button14_Click"  class="calculator__key"/>
              
  
                 <asp:Button ID="Button16" runat="server" Text="." class="calculator__key" OnClick="Button16_Click1" />  
                  <asp:Button ID="Button15" runat="server" Text="0" OnClick="Button15_Click" class="calculator__key"/>
                  <asp:Button ID="Button17" runat="server" Text="AC" class="calculator__key calculator__key--operator" OnClick="Button17_Click" color="#f0595f"/>
                 

                 <asp:Button ID="Button18" runat="server" Text="=" class="calculator__key calculator__key--enter" OnClick="Button18_Click"  Width="100px"/>

          </div>
      
</div>
  
    </form>
  
</body>
    
</html>
   

   

