<?xml version="1.0" encoding="UTF-8"?>

<!--
    Document   : HoaDon.xsl
    Created on : 10 tháng 4, 2025, 14:52
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
                <title>HoaDon.xsl</title>
                <style>
                    h2{
                    text-align: center;
                    }

                    p{
                    font-weight: bold;
                    }
                    
                    div{
                    width: 50%;
                    margin: 0px auto;
                    }
                    
                    table{
                    border-collapse: collapse;
                    width: 100%;
                    }
                    
                    table, th, td{
                    border: 1px solid black;
                    text-align: center;
                    }
                </style>
            </head>
            
            <body>
                <h2>PHIẾU MUA HÀNG</h2>
                <xsl:for-each select="hd">
                    <div>
                        <p>Hóa đơn: <xsl:value-of select="@mahd"/></p>
                        <xsl:for-each select="loaihang">
                            <p>Loại hàng: <xsl:value-of select="@tenloai"/></p>
                            <table>
                                <tr>
                                    <th>STT</th>
                                    <th>Tên hàng</th>
                                    <th>Số lượng</th>
                                    <th>Đơn giá</th>
                                    <th>Thành tiền</th>
                                </tr>
                                <xsl:for-each select="hang">
                                    <tr>
                                        <td>
                                            <xsl:value-of select="position()"/>
                                        </td>
                                        <td>
                                            <xsl:value-of select="tenhang"/>
                                        </td>
                                        <td>
                                            <xsl:value-of select="soluong"/>
                                        </td>
                                        <td>
                                            <xsl:value-of select="dongia"/>
                                        </td>
                                        <td>
                                            <xsl:variable name="tt" select="soluong * dongia"/>
                                            <xsl:choose>
                                                <xsl:when test="100 &lt; soluong and soluong &lt;= 200">
                                                    <xsl:value-of select="$tt - ($tt * 20 div 100)"/>
                                                </xsl:when>
                                                
                                                <xsl:when test="soluong &gt; 200">
                                                    <xsl:value-of select="$tt - ($tt * 30 div 100)"/>
                                                </xsl:when>
                                                
                                                <xsl:otherwise>
                                                    <xsl:value-of select="$tt"/>
                                                </xsl:otherwise>
                                            </xsl:choose>
                                        </td>
                                    </tr>
                                </xsl:for-each>
                            </table>
                        </xsl:for-each>
                    </div>
                </xsl:for-each>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>
