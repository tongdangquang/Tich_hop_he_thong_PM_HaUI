<?xml version="1.0" encoding="UTF-8"?>

<!--
    Document   : ChamCong.xsl
    Created on : 23 tháng 4, 2025, 12:58
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
                <title>ChamCong.xsl</title>
                <style>
                    table{
                    border-collapse: collapse;
                    width: 600px;
                    margin: 10px auto;
                    }
                    
                    table, th, td{
                    border: 1px solid black;
                    }
                    
                    th, td{
                    text-align: center;
                    padding: 5px;
                    }
                    
                    span{
                    font-weight: bold;
                    }
                </style>
            </head>
            <body>
                <table>
                    <tr>
                        <th colspan="6">BẢNG CHẤM CÔNG</th>
                    </tr>
                    <tr>
                        <th>STT</th>
                        <th>Mã NV</th>
                        <th>Ca làm việc</th>
                        <th>Giờ vào</th>
                        <th>Giờ ra</th>
                        <th>Làm đêm</th>
                    </tr>
                    <xsl:for-each select="ChamCong/NgayLamViec">
                        <tr>
                            <td colspan="6" style="text-align: left;">
                                <span>Ngày làm việc: </span>
                                <xsl:variable name="ngay" select="substring(@Ngay, 9, 2)"/>
                                <xsl:variable name="thang" select="substring(@Ngay, 6, 2)"/>
                                <xsl:variable name="nam" select="substring(@Ngay, 1, 4)"/>
                                <xsl:value-of select="concat($ngay, '/', $thang, '/', $nam)"/>
                            </td>
                        </tr>
                        <xsl:for-each select="NhanVien">
                            <tr>
                                <td>
                                    <xsl:value-of select="position()"/>
                                </td>
                                <td>
                                    <xsl:value-of select="@MaNV"/>
                                </td>
                                <td>
                                    <xsl:value-of select="CaLamViec"/>
                                </td>
                                <td>
                                    <xsl:value-of select="GioVao"/>
                                </td>
                                <td>
                                    <xsl:value-of select="GioRa"/>
                                </td>
                                <td>
                                    <xsl:choose>
                                        <xsl:when test="CaLamViec = 'C3'">x</xsl:when>
                                        <xsl:otherwise> </xsl:otherwise>
                                    </xsl:choose>
                                </td>
                            </tr>
                        </xsl:for-each>
                    </xsl:for-each>
                </table>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>
