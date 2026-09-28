# EventEase — Blazor Event Management App

A course demonstration built with C#, .NET 8, and Blazor Interactive Server. Browse events, edit event cards, register attendees, preserve a profile during navigation, and track attendance.

## Run locally

Install the **.NET 8 SDK** (not only the runtime) from https://dotnet.microsoft.com/download/dotnet/8.0. Open this folder in VS Code, then select Terminal > New Terminal:

```bash
dotnet restore
dotnet build
dotnet run --urls http://localhost:5075
```

Open http://localhost:5075. Keep the terminal open while using the app. Stop with Ctrl+C. No database, API keys, or external NuGet packages are needed.

## Features and rubric mapping

| Assignment item | Implementation / remaining action |
| --- | --- |
| Public GitHub repository | Upload this folder's contents to your own public repository; see START-HERE.txt. |
| Event Card with fields and two-way binding | Components/Shared/EventCard.razor uses InputText/InputDate with @bind-Value for name, location, and date, validation, save, and cancel. Complete the required Copilot activity yourself and document it. |
| Routing and debugging | Routes.razor; /, /events/{Id:int}, /register/{Id:int}, /attendance, /session; missing IDs and unknown addresses show a friendly recovery page. |
| Performance and validation | In-memory scoped service, stable @key values, no repeated network fetching, bounded inputs, service-level validation, duplicate and capacity checks. This small demo does not claim benchmarked performance gains. |
| Advanced features | Reusable RegistrationForm, UserSession profile state, attendance filters, check-in toggles, and live counts. |
| Copilot development summary | COPILOT-WORKLOG.md provides prompts and an honest completion template. No Copilot use is claimed by this package. |

## Project structure

- Program.cs: app startup and scoped dependency injection.
- Components/App.razor and Routes.razor: document shell, interactive mode, and routing.
- Components/Pages: event listing, event details, registration, attendance, session, and error pages.
- Components/Shared: reusable event card, registration form, and missing-page component.
- Models: event and registration models with data annotations.
- Services: event/registration storage and a convenience user profile.
- wwwroot/app.css: responsive layout and accessible focus styles.
- .github/workflows/build.yml: build validation after pushing to GitHub.

## State and limits

This is an educational demo with per-circuit memory. Data survives internal navigation but resets on a full reload, a new browser tab, closing the app, or a server restart. Separate browser sessions have separate event data and registrations. The attendee table contains only the current session's entries. Clearing the saved profile leaves attendance records intact. A user profile is not authentication. Production deployment would need a database, authentication, authorisation, and persistent session handling.

Sample events are scheduled relative to the day the app starts. No real attendee information is bundled. Use fictitious details when testing or sharing screenshots.

## Verification status

Source structure, project XML, file references, and packaging were reviewed in the preparation environment. **Compilation and browser behaviour were not verified here because the .NET SDK was unavailable and its download could not be reached.** Run the commands above and follow TEST-CHECKLIST.md before submission. The GitHub Actions build workflow is included for an additional compiler check; a passing build does not replace interactive testing.

## Submission

Your assignment requests a **public GitHub repository URL**, not the ZIP file or a localhost URL. Suggested project title: **EventEase — Blazor Event Management Application**.

This package was generated with ChatGPT assistance. Complete the Microsoft Copilot activities required by your course and record actual prompts, changes, and test results in COPILOT-WORKLOG.md before writing your submission summary. Follow any course rules on acknowledging AI assistance.

## Technical references

- https://learn.microsoft.com/en-us/aspnet/core/blazor/components/render-modes?view=aspnetcore-8.0
- https://docs.github.com/en/repositories/working-with-files/managing-files/adding-a-file-to-a-repository
