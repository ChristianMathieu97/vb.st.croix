'This class allows you to handle specific events on the settings class:
' The SettingChanging event is raised before a setting's value is changed.
' The PropertyChanged event is raised after a setting's value is changed.
' The SettingsLoaded event is raised after the setting values are loaded.
' The SettingsSaving event is raised before the setting values are saved.
Partial Friend NotInheritable Class MySettings
    Public WriteOnly Property RunTimeConnectionString()
        Set(ByVal value)
            My.Settings("SaleForcConnectionString") = value
        End Set
    End Property

    Private Sub MySettings_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetEnvironmentVariable("SalesForceDBPath"))
        'AppDomain.CurrentDomain.SetData("DataDirectory", dbPath)
    End Sub
End Class
