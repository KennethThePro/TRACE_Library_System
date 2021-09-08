Partial Class TRACE_Library_SystemDataSet
    Partial Public Class LoginRecordDataTable
        Private Sub LoginRecordDataTable_LoginRecordRowChanging(sender As Object, e As LoginRecordRowChangeEvent) Handles Me.LoginRecordRowChanging

        End Sub

    End Class

    Partial Public Class StaffDataTable
        Private Sub StaffDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If e.Column.ColumnName = Staff_IDColumn.ColumnName Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace TRACE_Library_SystemDataSetTableAdapters

    Partial Public Class StaffTableAdapter
    End Class
End Namespace
