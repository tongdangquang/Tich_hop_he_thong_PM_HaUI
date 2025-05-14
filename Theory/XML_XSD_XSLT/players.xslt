<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<style>
				table {
				border-collapse: collapse;
				width: 560px;
				height: 120px;
				}

				table, th, td {
				border: 1px solid black;
				text-align: center;
				}
			</style>
			<head>
				<title>Thống kê trận đấu</title>
			</head>
			<body>
				<h2>Thống kê cầu thủ</h2>
				<table >
					<tr>
						<th>STT</th>
						<th>Họ tên</th>
						<th>Số áo</th>
						<th>Bàn thắng</th>
						<th>Kiến tạo</th>
						<th>Số cú sút</th>
						<th>Tổng số đóng hóp</th>
						<th>Xếp hạng</th>
					</tr>
						<!--Sử dụng vòng lặp for-each để duyệt qua từng phần tử trong xml-->
						<xsl:for-each select="bongda/cauthu">
							<!--Sử dụng sort để sắp xếp các giá trị-->
							<xsl:sort select="@soao" order="descending"/>
							<!--Sử dụng if với các điều kiện kiểm tra tương ứng-->
							<xsl:if test="banthang > 0">
								<!--Sử dụng toán tử cộng, trừ, nhân, div() - chia tương ứng-->
								<!--Khai báo và gán giá trị cho biến x = banthang + kientao-->
								<xsl:variable name="x" select="banthang + kientao"/>
								<tr>
									<td>
										<!--Sử dụng position() để hiển thị số thứ tự-->
										<xsl:value-of select="position()"/>
									</td>
									<td>
										<!--Truy vấn giá trị trong các cặp thẻ bằng attribute select=""-->
										<xsl:value-of select="hoten" />
									</td>
									<td>
										<xsl:value-of select="@soao" />
										<!--Sử dụng @ trước tên attribute khi truy vấn-->
									</td>
									<td>
										<xsl:value-of select="banthang" />
									</td>
									<td>
										<xsl:value-of select="kientao" />
									</td>
									<td>
										<xsl:value-of select="socusut" />
									</td>
									<td>
										<xsl:value-of select="$x"/> <!--Sử dụng $ trước tên biến để gọi biến-->
									</td>
									<td>
										<!--Sử dụng choose-when-otherwise tương tự như switch-case trong ngôn ngữ lập trình-->
										<xsl:choose>
											<xsl:when test="$x &lt;= 1">Kém</xsl:when>
											<xsl:when test="$x = 2">Khá</xsl:when>
											<xsl:otherwise>Tốt</xsl:otherwise>
										</xsl:choose>
									</td>
								</tr>
							</xsl:if>
						</xsl:for-each>
					<tr>
						<th colspan="2">Tổng hợp</th>
						<th>
							<xsl:value-of select="sum(bongda/cauthu/banthang)"/>
						</th>
						<th>
							<xsl:value-of select="sum(bongda/cauthu/kientao)"/>
						</th>
						<th>
							<!--Sử dụng hàm sum(), count(), mod(phần dư), ceiling(làm tròn lấy giá trị trần), 
							floor(làm tròn lấy giá trị sàn), round(làm tròn), concat(s1, s2) - nối chuỗi-->
							<xsl:value-of select="sum(bongda/cauthu/socusut)"/>
						</th>
					</tr>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
