Public Class Physician
	Public Property id As Integer
	Public Property firstName As String
	Public Property lastName As String
	Public Property specialty As Spec
	Public Enum Spec As Integer
		Family
		Obstetrics
		Pediatrics
		Orthopedics
	End Enum

	Public Shared SpecType() As String = {"Family",
										   "Obstetrics",
										   "Pediatrics",
										   "Orthopedics"}

	Public Sub New(ByVal phyID As Integer, ByVal phyFirst As String, ByVal phyLast As String, ByVal phySpec As Integer)

		id = phyID
		firstName = phyFirst
		lastName = phyLast
		specialty = CType(phySpec, Spec)

	End Sub

	' Parameterless constructor used for XML serialization
	Public Sub New()

	End Sub

	Public Overrides Function ToString() As String
		'Return CType(id, String) & " - " & firstName & " " & lastName & " : " & specialty
		Return CType(id, String) & " - " & firstName & " " & lastName
	End Function

End Class
