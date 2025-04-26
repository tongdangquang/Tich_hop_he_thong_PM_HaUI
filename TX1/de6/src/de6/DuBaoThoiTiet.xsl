<?xml version="1.0" encoding="UTF-8"?>

<!--
    Document   : DuBaoThoiTiet.xsl
    Created on : 24 tháng 4, 2025, 17:05
    Author     : quang
    Description:
        Purpose of transformation follows.
-->

<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html"/>

    <!-- TODO customize transformation rules 
         syntax recommendation http://www.w3.org/TR/xslt 
    -->
    <xsl:template match="/">
        <html>
            <head>
                <title>DuBaoThoiTiet.xsl</title>
                <style>
                    .container{
                    width: 50%;
                    margin: 10px auto;
                    }
                    
                    h2, th{
                    text-align: center;
                    }
                    
                    .content{
                    margin: 20px 0px;
                    }
                    
                    table{
                    width: 100%;
                    margin: 3px auto;
                    border-collapse: collapse;
                    }
                    
                    table, th, td{
                    border: 1px solid black;
                    }
                    
                    th, td{
                    padding: 5px;
                    }
                    
                    p{
                    padding: 0px;
                    margin: 0px;
                    }
                    
                    th{
                    background-color: yellowgreen;
                    }
                </style>
            </head>
            <body>
                <div class="container">
                    <h2>DỰ BÁO THỜI TIẾT</h2>
                    <xsl:for-each select="dubaothoitiet/thoitiet">
                        <div class="content">
                            <p>Ngày: <xsl:value-of select="@ngay"/></p>
                            <table>
                                <tr>
                                    <th>STT</th>
                                    <th>Khu vực</th>
                                    <th>Kiểu thời tiết</th>
                                    <th>Nhiệt độ cao nhất</th>
                                    <th>Nhiệt độ thấp nhất</th>
                                </tr>
                                <xsl:for-each select="khuvuc">
                                    <tr>
                                        <td align="center">
                                            <xsl:value-of select="position()"/>
                                        </td>
                                        <td align="center">
                                            <xsl:value-of select="@ma"/>
                                        </td>
                                        <td align="center">
                                            <xsl:choose>
                                                <xsl:when test="kieuthoitiet = 'Nắng'">
                                                    <div>
                                                        <p>Nắng</p>
                                                        <img src="img/nang.jpg" alt=""/>
                                                    </div>
                                                </xsl:when>
                                                
                                                <xsl:when test="kieuthoitiet = 'Mưa'">
                                                    <div>
                                                        <p>Mưa</p>
                                                        <img src="img/mua.jpg" alt=""/>
                                                    </div>
                                                </xsl:when>
                                                
                                                <xsl:when test="kieuthoitiet = 'Mây'">
                                                    <div>
                                                        <p>Mây</p>
                                                        <img src="img/may.jpg" alt=""/>
                                                    </div>
                                                </xsl:when>
                                                
                                                <xsl:otherwise>
                                                    <p> </p>
                                                </xsl:otherwise>
                                            </xsl:choose>
                                        </td>
                                        <td align="right">
                                            <xsl:value-of select="nhietdocaonhat"/>
                                        </td>
                                        <td align="right">
                                            <xsl:value-of select="nhietdothapnhat"/>
                                        </td>
                                    </tr>
                                </xsl:for-each>
                            </table>  
                        </div>
                    </xsl:for-each>
                </div>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>
