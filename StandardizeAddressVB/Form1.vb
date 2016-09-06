Imports StandardizeAddressVB.AddrService


Public Class Form1
    Dim mySrv As New StandardizeAddressService

    Private Sub Standardize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Standardize.Click
        ClearLabels()
        Dim resp As AddrResponse
        resp = mySrv.checkAddress(PopulateTO())

        If (resp.Success) Then
            PopulateLabels(resp.Addresses(0))
        Else
            lblAddr1.Text = resp.FailureDesc
        End If

    End Sub



    Private Sub ClearLabels()
        lblAddr1.Text = ""
        lblAddr2.Text = ""
        lblCity.Text = ""
        lblState.Text = ""
        lblZip.Text = ""
        lblConf.Text = ""
    End Sub




    Private Sub PopulateLabels(ByVal addrTO As CDQpAddressTO)
        lblAddr1.Text = addrTO.Addr1
        lblAddr2.Text = addrTO.Addr2
        lblCity.Text = addrTO.City
        lblState.Text = addrTO.State
        lblZip.Text = addrTO.Zip
        lblConf.Text = addrTO.Confidence.ToString + "%"
    End Sub


    Function PopulateTO()
        Dim addrTO As New CDQpAddressTO
        addrTO.Addr1 = AddressLine1.Text
        addrTO.Addr2 = AddressLine2.Text
        addrTO.City = City.Text
        addrTO.State = State.Text
        addrTO.Zip = Zip.Text

        Return addrTO
    End Function


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearLabels()
        mySrv.Url = "http://adrwslb-fhitest.cvty.com/StandardizeAddressTEST/StandardizeAddress"
    End Sub
End Class
