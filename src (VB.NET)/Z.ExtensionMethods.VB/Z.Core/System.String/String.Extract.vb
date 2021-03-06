
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Linq

Public Module Extensions_494

	''' <summary>
	'''     A string extension method that extracts this object.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="predicate">The predicate.</param>
	''' <returns>A string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Extract(this As String, predicate As Func(Of Char, Boolean)) As String
		Return New String(this.ToCharArray().Where(predicate).ToArray())
	End Function
End Module


