<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html"/>
    <xsl:template match="/">
        <html>
            <head>
                <title>ThuVien.xsl</title>
                <style>
                    div{
                    width: 50%;
                    margin: 30px auto;
                    }
                    
                    h2{
                    text-align: center;
                    }
                    
                    p{
                    font-weight: bold;
                    }
                    
                    table{
                    border-collapse: collapse;
                    width: 100%;
                    }
                    
                    table, th, td {
                    border: 1px solid black;
                    }
                    
                    td{
                    text-align: center;
                    }
                </style>
            </head>
            
            <body>
                <h2>DANH MỤC SÁCH</h2>
                
                <xsl:for-each select="TV/nhaxb">
                    <div>
                        <p>Nhà xuất bản: <xsl:value-of select="@tennxb"/></p>
                        <table>
                            <tr>
                                <th>STT</th>
                                <th>Tên sách</th>
                                <th>Số trang</th>
                                <th>Giá</th>
                            </tr>
                            <xsl:for-each select="sach">
                                <tr>
                                    <td>
                                        <xsl:value-of select="position()"/>
                                    </td>                                
                                    <td>
                                        <xsl:value-of select="tensach"/>
                                    </td>
                                    <td>
                                        <xsl:value-of select="sotrang"/>
                                    </td>
                                    <td>
                                        <xsl:variable name="p" select="sotrang"/>
                                        <xsl:choose>
                                            <xsl:when test="$p &lt;= 100">
                                                <xsl:value-of select="$p * 4000"/>
                                            </xsl:when>
                                            
                                            <xsl:when test="$p &lt;= 150">
                                                <xsl:value-of select="(100 * 4000) + (($p - 100) * 3000)"/>
                                            </xsl:when>
                                            
                                            <xsl:otherwise>
                                                <xsl:value-of select="(100 * 4000) + (50 * 3000) + (($p - 150) * 2000)"/>
                                            </xsl:otherwise>
                                        </xsl:choose>
                                    </td>
                                </tr>
                            </xsl:for-each>
                        </table>
                    </div>
                    
                </xsl:for-each>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
