
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/ArrayOfOrder">
<html>
    <head>
        <title>Order</title>
    </head>
<body>
    <ul>
        <xsl:for-each select="Order">
            <li>
                <xsl:value-of select="CliName"/>
            </li>
            <li>
                 <xsl:value-of select="OrderId"/>
            </li>
            <li>
                <xsl:value-of select="ProName"/>
            </li>
            <li>
                <xsl:value-of select="Quantity"/>
            </li>
            <li>
                <xsl:value-of select="Price"/>
            </li>
         </xsl:for-each>
        </ul>
       </body>
      </html>
     </xsl:template>
</xsl:stylesheet>