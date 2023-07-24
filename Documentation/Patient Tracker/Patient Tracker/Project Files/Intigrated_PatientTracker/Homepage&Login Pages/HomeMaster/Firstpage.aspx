<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Firstpage.aspx.cs" Inherits="HomeMaster.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style type="text/css">
      
      .center-justified {
  text-align: justify;
  margin: 0 auto;
  width: 30em;
}
      
ul {list-style-type:none; margin:0; padding:0; overflow:hidden;
           width: 1233px;
       }
ul li {float:left;
            height: 42px;
            
        }
ul li a { display:block; text-decoration:none; text-align:center; padding:9px 20px 9px 20px; font-family:Arial; font-size:14pt; font-weight:bold; color:#ffffff; text-transform:uppercase; border-top:1px solid #9cbed2; border-right:1px solid #7094B2; border-left:1px solid #94b5c8; background: #525200 url(bg.gif) repeat-x; text-transform:uppercase; letter-spacing:.08em;
            width: 266px;
            height: 27px;
        }
ul li a:hover,

{color:#a2becf; border-top:1px solid #72a0ba; border-right:1px solid #2a4a5f; border-left:1px solid #8cb3c9; background: #3b6a85 url(bg2.gif) repeat-x}
ul li a.first {border-left:0}
ul li a.last {border-right:0}

        .style
        {
            width: 1167px;
            }

        .style2
        {
            width: 1298px;
            height: 35px;
        }

        </style>

  <div>
    <table class="style">              
        <tr>
            <td class="style2" width="100px">
                <ul>
<li><a class="first" href="Clerklogin.aspx">Clerk</a></li>
<li><a href="DoctorLogin.aspx">Doctor</a></li>
<li><a href="PatientLogin.aspx">Patient</a></li>
<li><a href="Contactus.aspx">Contact Us</a></li>
</ul>

                &nbsp;</td>
        </tr>
     
    </table>

    </div>

<div>
          <div style="float:left;width:49%; height:170px;">    
          <marquee behavior="alternate" direction="right"> <img  src="Home Images/logo.png" alt="Logo"
            style="width: 400px; height: 478%"/></marquee>
            </div>

<div style="height: 376px; width: 624px;">
  <p style="float:right;width:535px; height:351px; z-index: 1; left: 702px; top: 298px; position: absolute;" 
        class="center-justified">
         Medical professionals understand that determining room availability, 
         knowing if a patient has recently been checked-in, registered, treated, 
         or why they are waiting, are important, but difficult tasks in a busy healthcare facility. 
         We have worked with healthcare industry experts to design a simple, affordable solution, 
         currently managing patient flow in many different types of healthcare organizations.<br /> 
         <br /> 
            Our Patient Tracking and Patient Sign-In Systems can be used in any setting 
        which requires patient flow management and a high level of patient satisfaction. 
        Healthcare organizations will find an immediate benefit through the use of the web-based applications,
        which assist in checking in patients, monitoring wait times, providing status updates, analyzing staff productivity, and more.<br />
        <br /> 
            As PatientTrak applications are cloud-based, hosted systems, 
        they only require a web browser and Internet connection, 
        resulting in a method of software delivery which is affordable, 
        quick-to-implement, and simple to use. 
        The ability to run a full-featured patient tracking or check-in system has never been easier.<br />
 
            </p>
            </div>

 </div>
</asp:Content>
