<?xml version="1.0" encoding="UTF-8"?>

<!--
    Document   : THUVIEN.xsl
    Created on : 27 tháng 4, 2025, 10:59
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
                <title>THUVIEN.xsl</title>
                <style>
                    span{
                    font-weight: bold;
                    }
                    
                    p{
                    margin: 25px 0px 5px 0px;
                    }
                    
                    h3{
                    text-align: center;
                    }
                    
                    table{
                    border-collapse: collapse;
                    width: 100%;
                    }
                    
                    table, th, td{
                    border: 1px solid black;
                    }
                    
                    th, td{
                    text-align: center;
                    padding: 5px;
                    }
                    
                    .container{
                    width: 50%;
                    margin: 20px auto;
                    }
                    
                    
                </style>
            </head>
            
            <body>
                <div class="container">
                    <h3>Danh mục sách</h3>
                    <xsl:for-each select="TV/NhaXB">
                        <p>
                            <span>Nhà xuất bản: </span>
                            <xsl:value-of select="@TenNXB"/>
                        </p>
                        
                        <table>
                            <tr>
                                <th>STT</th>
                                <th>Tên sách</th>
                                <th>Số trang</th>
                                <th>Giá</th>
                            </tr>
                            <xsl:for-each select="Sach">
                                <tr>
                                    <td>
                                        <xsl:value-of select="position()"/>
                                    </td>
                                    <td style="text-align: left;">
                                        <xsl:value-of select="TenSach"/>
                                    </td>
                                    <td>
                                        <xsl:value-of select="SoTrang"/>
                                    </td>
                                    <td>
                                        <xsl:choose>
                                            <xsl:when test="SoTrang &lt;= 100">
                                                <xsl:value-of select="SoTrang * 4000"/>
                                            </xsl:when>
                                            
                                            <xsl:when test="SoTrang > 100 and SoTrang &lt;= 150">
                                                <xsl:value-of select="(100 * 4000) + ((SoTrang - 100) * 3000)"/>
                                            </xsl:when>
                                            
                                            <xsl:when test="SoTrang > 150">
                                                <xsl:value-of select="(100 * 4000) + (50 * 3000) + ((SoTrang - 150) * 2000)"/>
                                            </xsl:when>
                                        </xsl:choose>
                                    </td>
                                </tr>
                            </xsl:for-each>
                        </table>
                    </xsl:for-each>
                </div>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>
