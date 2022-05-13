Public Class Customer
    'how to view the database layout
    'how to update values w database information
    '

    Private m_custID As Integer ' uint maybe? Private m_firstname As String
    Private m_firstname As String
    Private m_lastname As String
    Private m_city As String
    Private m_zip As String 'DB has it as varchar and not int for whatever reason
    Private m_state As String
    Private m_address As String

    Public Property City() As String
        Get
            Return m_city
        End Get
        Set(ByVal value As String)
            m_city = value
        End Set
    End Property

    Public Property Firstname As String
        Get
            Return m_firstname
        End Get
        Set(value As String)
            m_firstname = value
        End Set
    End Property

    Public Property Lastname() As String
        Get
            Return m_lastname
        End Get
        Set(ByVal value As String)
            m_lastname = value
        End Set
    End Property

    Public Property State() As String
        Get
            Return m_state
        End Get
        Set(ByVal value As String)
            m_state = value
        End Set
    End Property

    Public Property CustID() As Integer
        Get
            Return m_custID
        End Get
        Set(ByVal value As Integer)
            m_custID = value
        End Set
    End Property

    Public Property Zip As String
        Get
            Return m_zip
        End Get
        Set(value As String)
            m_zip = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return m_address
        End Get
        Set(value As String)
            m_address = value
        End Set
    End Property

    ''' <summary>
    ''' creates a new instance of the new customer
    ''' </summary>

    Public Sub New()

    End Sub


    ''' <summary>
    ''' Overloads customer to take in all field types
    ''' </summary>
    ''' <param name="custID"></param>
    ''' <param name="firstname"></param>
    ''' <param name="lastname"></param>
    ''' <param name="city"></param>
    ''' <param name="zip"></param>
    ''' <param name="state"></param>
    Public Sub New(custID As Integer,
                   firstname As String,
                   lastname As String,
                   city As String,
                   zip As String,
                   state As String, address As String)
        Me.CustID = custID
        Me.Firstname = firstname
        Me.Lastname = lastname
        Me.City = city
        Me.Zip = zip
        Me.State = state
        Me.Address = address
    End Sub

    'todo: get customer


End Class
