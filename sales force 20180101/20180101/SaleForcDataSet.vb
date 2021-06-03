

Partial Public Class SaleForcDataSet
    Partial Class DefaultsDataTable

        Private Sub DefaultsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SupportEmailColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class CustomerStatusDataTable

        Private Sub CustomerStatusDataTable_CustomerStatusRowChanging(ByVal sender As System.Object, ByVal e As CustomerStatusRowChangeEvent) Handles Me.CustomerStatusRowChanging

        End Sub

        Private Sub CustomerStatusDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me._cust_noColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class ShipViaCodeDataTable

        Private Sub ShipViaCodeDataTable_ShipViaCodeRowChanging(ByVal sender As System.Object, ByVal e As ShipViaCodeRowChangeEvent) Handles Me.ShipViaCodeRowChanging

        End Sub

    End Class

    Partial Class WSErrorMsgDataTable

        Private Sub WSErrorMsgDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.primarykeyfieldColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace SaleForcDataSetTableAdapters
    
    Partial Public Class ws_ord_headTableAdapter
    End Class
End Namespace

Namespace SaleForcDataSetTableAdapters
    
    Partial Public Class WSErrorMsgTableAdapter
    End Class
End Namespace

Namespace SaleForcDataSetTableAdapters
    
    Partial Public Class ItemTableAdapter
    End Class
End Namespace

Namespace SaleForcDataSetTableAdapters
    
    Partial Public Class SeasonTableAdapter
    End Class
End Namespace

Namespace SaleForcDataSetTableAdapters
    
    Partial Public Class CustomerStatusTableAdapter
    End Class
End Namespace

Namespace SaleForcDataSetTableAdapters
    
    Partial Public Class DefaultsTableAdapter
    End Class
End Namespace
