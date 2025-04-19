<?xml version="1.0" encoding="UTF-8"?>

<!--
    Document   : DangKyNghi.xsl
    Created on : 18 tháng 4, 2025, 13:16
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
                <title>DangKyNghi.xsl</title>
                <style>
                    table{
                    border-collapse: collapse;
                    width: 600px;
                    margin: 20px auto;
                    }
                    
                    table, th, td{
                    border: 1px solid black;
                    }
                    
                    th, td{
                    padding: 5px;
                    }
                    td{
                    text-align: center;
                    }
                </style>
            </head>
            <body>
                <xsl:for-each select="dangky/ngaylamviec">
                    <table>
                        <tr>
                            <th colspan="6">DANH SÁCH ĐĂNG KÝ NGHỈ</th>
                        </tr>
                        
                        <tr>
                            <td colspan="6" style="text-align: left;">
                                <span style="font-weight: bold;">Ngày làm việc: </span> 
                                <xsl:value-of select="@ngay"/>
                            </td>
                        </tr>
                        
                        <tr>
                            <th>STT</th>
                            <th>Mã NV</th>
                            <th>Lý do</th>
                            <th>Đơn vị</th>
                            <th>Trang thái</th>
                            <th>Ghi chú</th>
                        </tr>
                        
                        <xsl:for-each select="nhanvien">
                            <tr>
                                <td>
                                    <xsl:value-of select="position()"/>
                                </td>
                                <td>
                                    <xsl:value-of select="@manv"/>
                                </td>
                                <td>
                                    <xsl:value-of select="lydo"/>
                                </td>
                                <td>
                                    <xsl:value-of select="donvi"/>
                                </td>
                                <td>
                                    <xsl:value-of select="trangthai"/>
                                </td>
                                <td>
                                    <xsl:choose>
                                        <xsl:when test="donvi = 0.5">
                                            Nghỉ nửa ngày
                                        </xsl:when> 
                                    </xsl:choose>
                                    
                                </td>
                            </tr>
                        </xsl:for-each>
                    </table> 
                </xsl:for-each>
                
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>
