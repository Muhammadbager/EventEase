# EventEase - Event Management Application

A modern, full-featured event management application built with Blazor Server and .NET 9. EventEase allows users to discover, register for, and manage events with an intuitive user interface and comprehensive state management.

## 🚀 Features

### Core Functionality
- **Event Discovery**: Browse through curated events with detailed information
- **User Registration**: Streamlined registration process with comprehensive validation
- **Session Management**: Persistent user sessions with login/logout functionality
- **Attendance Tracking**: Monitor event participation and user statistics
- **Personal Dashboard**: User-specific dashboard showing registered events and activity

### Advanced Features
- **Enhanced Registration Form**: Multi-field validation with real-time feedback
- **State Management**: Comprehensive session tracking and user preferences
- **Responsive Design**: Mobile-first design that works on all screen sizes
- **Error Handling**: Graceful error management with user-friendly messages
- **Loading States**: Smooth user experience with loading indicators

## 🛠 Technology Stack

- **.NET 9**: Latest .NET framework
- **Blazor Server**: Interactive web UI framework
- **Bootstrap 5**: Modern CSS framework for responsive design
- **Bootstrap Icons**: Professional icon library
- **C# 12**: Latest C# language features

## 📁 Project Structure

```
EventEase.App/
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor          # Main application layout
│   │   └── NavMenu.razor             # Navigation menu
│   ├── Models/
│   │   └── RegistrationModel.cs      # Registration data model
│   ├── Pages/
│   │   ├── Home.razor                # Landing page
│   │   ├── EventList.razor           # Events listing page
│   │   ├── EventDetails.razor        # Event details page
│   │   ├── Registration.razor        # Registration form
│   │   └── Dashboard.razor           # User dashboard
│   ├── Services/
│   │   ├── SessionState.cs           # User session management
│   │   └── AttendanceService.cs      # Attendance tracking
│   └── EventCard.razor               # Event card component
├── wwwroot/
│   └── app.css                       # Custom styling
└── Program.cs                        # Application configuration
```

## 🎯 Key Components

### Registration System
- **Multi-field validation** with comprehensive error handling
- **Real-time form validation** with user-friendly feedback
- **Session persistence** for seamless user experience
- **Duplicate registration prevention**

### State Management
- **User session tracking** with login/logout functionality
- **Registration history** and user preferences
- **Cross-component state sharing** for consistent UI

### Attendance Tracking
- **Detailed registration records** with user information
- **Attendance statistics** and analytics
- **Registration cancellation** functionality
- **User-specific event tracking**

## 🚀 Getting Started

### Prerequisites
- .NET 9 SDK
- Visual Studio 2022 or VS Code
- Git

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/EventEase.git
   cd EventEase/EventEase.App
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the application**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Open in browser**
   Navigate to `https://localhost:5001` or `http://localhost:5000`

## 🎨 User Interface

### Home Page
- **Hero section** with call-to-action buttons
- **Feature highlights** showcasing app capabilities
- **User statistics** for logged-in users
- **Responsive design** for all screen sizes

### Event Management
- **Event listing** with pagination and filtering
- **Detailed event pages** with registration options
- **Registration status** indicators
- **Attendance tracking** and statistics

### User Dashboard
- **Personal statistics** and activity tracking
- **Registered events** management
- **Quick actions** for event navigation
- **Recent activity** timeline

## 🔧 Development with Microsoft Copilot

This project was developed using Microsoft Copilot for enhanced productivity and code quality:

### Copilot Assistance Areas

1. **Component Generation**: Copilot helped generate foundational components like EventCard with proper data binding
2. **Routing Implementation**: Assisted in setting up proper routing with error handling
3. **Performance Optimization**: Guided optimization of components and state management
4. **Advanced Features**: Helped implement registration forms, session management, and attendance tracking
5. **UI/UX Enhancement**: Assisted in creating responsive designs and user-friendly interfaces

### Copilot Benefits
- **Faster Development**: Rapid prototyping and component generation
- **Code Quality**: Consistent patterns and best practices
- **Error Prevention**: Proactive error handling and validation
- **Feature Implementation**: Complex features implemented efficiently

## 📊 Performance Features

- **Virtualization**: Efficient rendering of large event lists
- **Lazy Loading**: On-demand component loading
- **State Optimization**: Efficient state management patterns
- **Responsive Design**: Mobile-first approach for optimal performance

## 🧪 Testing

The application includes comprehensive error handling and validation:
- **Form validation** with real-time feedback
- **Error boundaries** for graceful error handling
- **Loading states** for better user experience
- **Input validation** with user-friendly messages

## 🚀 Deployment

The application is production-ready with:
- **Optimized build** configuration
- **Error handling** for production scenarios
- **Security considerations** with proper validation
- **Performance optimizations** for scalability

## 📝 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📞 Support

For support and questions, please open an issue in the GitHub repository.

---

**Built with ❤️ using Microsoft Copilot and .NET 9**
