Public Class Patient
	' Properties must be Public 
	Public Property id As Integer ' Patient id must be unique
	Public Property firstName As String
	Public Property lastName As String
	Public Property dob As String ' Date of Birth Property
	Public Property phone As String
	Public Property email As String
	Public Property plan As String ' Plan will consist of HMO/PPO
	Public Property subId As Integer ' Subscriber ID
	Public Property planId As Integer
	' Insurance is Optional
	Public Property insurance As String

	' Create Constructor for Patient. pInsurance is an optional parameter
	Public Sub New(ByVal pId As Integer, pFirst As String, ByVal pLast As String, ByVal pDoB As String,
				   ByVal pPhone As String, ByVal pEmail As String, ByVal pPlan As String, ByVal pSubId As Integer,
				   ByVal pPlanId As Integer, Optional ByVal pInsurance As String = "")

		id = pId
		firstName = pFirst
		lastName = pLast
		dob = pDoB
		phone = pPhone
		email = pEmail
		plan = pPlan
		subId = pSubId
		planId = pPlanId
		insurance = pInsurance

	End Sub

	' Parameterless constructor used for XML serialization
	Public Sub New()

	End Sub

	Public Overrides Function ToString() As String
		Return CType(id, String) & " - " & firstName & " " & lastName
	End Function

End Class
