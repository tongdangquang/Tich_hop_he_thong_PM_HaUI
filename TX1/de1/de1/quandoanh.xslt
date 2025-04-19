<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
	xmlns:x="http://tempuri.org/quandoanh.xsd"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>
				<title>Quân Doanh</title>
				<style>
					table{
					border-collapse: collapse;
					}

					th, td{
					height: 20px;
					}

					th{
					background: blue;
					}
					
					.chiensi_table, .chiensi_table th, .chiensi_table td{
					border: 1px solid black;
					}
					
					div{
					margin: 20px 10px;
					}
				</style>
			</head>
			<body>
				<xsl:for-each select="x:quandoanh/x:tieudoi">
					<div>
						<table class="info_table">
							<tr>
								<td>
									Tên tiểu đội: <xsl:value-of select="x:tentd"/>
								</td>
							</tr>
							<tr>
								<td>
									Mã tiểu đội: <xsl:value-of select="@matd"/>
								</td>
							</tr>
							<tr>
								<td>Danh sách chiến sĩ</td>
							</tr>
						</table>
						<table class="chiensi_table">
							<tr>
								<th>STT</th>
								<th>Họ tên</th>
								<th>Tuổi</th>
								<th>Ngày nhập ngũ</th>
								<th>Tiểu sử</th>
								<th>Lương</th>
							</tr>
							<xsl:for-each select="x:chiensi">
								<tr>
									<td>
										<xsl:value-of select="position()"/>
									</td>
									<td>
										<xsl:value-of select="x:hoten"/>
									</td>
									<td>
										<xsl:value-of select="x:tuoi"/>
									</td>
									<td>
										<xsl:value-of select="x:ngaynhapngu"/>
									</td>
									<td>
										<xsl:value-of select="x:tieusu"/>
									</td>
									<td>
										<xsl:value-of select="x:luong"/>
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
