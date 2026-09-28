# Microsoft Copilot worklog — complete before submission

The initial package was generated with ChatGPT assistance. No Microsoft Copilot interactions were performed during its creation. Your rubric explicitly asks for Copilot use, so complete the activities below using the Copilot tool specified in your course and document the actual results.

## 1. Generate and compare the foundational Event Card

Suggested prompt:
> Generate a Blazor EventCard component with event name, date, and location; use two-way binding for editable fields, DataAnnotationsValidator, save/cancel behaviour, and a link to event details. Explain the parameters and binding syntax.

Compare Copilot's result with Components/Shared/EventCard.razor. Integrate appropriate improvements while keeping the EventItem model and existing parameter contract, then build and test.

Actual date/tool: [complete]
Suggestions accepted or rejected, and why: [complete]
Files changed: [complete]
Test result: [complete]

## 2. Review and debug routing

Share Routes.razor, EventDetails.razor, Register.razor, and NotFoundPage.razor.

Suggested prompt:
> Review these Blazor routes for valid IDs, missing numeric IDs, non-numeric parameters, unknown paths, and changes between event IDs. Identify any real bugs and propose fixes without inventing problems.

Actual findings: [complete]
Changes made or explanation if no changes were needed: [complete]
Addresses tested and outcomes: [complete]

## 3. Review validation and performance

Share RegistrationForm.razor, EventStore.cs, Home.razor, and Attendance.razor.

Suggested prompt:
> Check registration validation, duplicate emails ignoring case, capacity limits, and render-time work. Suggest proportionate improvements for a small Blazor app. Explain what @key does and does not optimise. Do not claim measured speedups without a benchmark.

Actual suggestions: [complete]
Changes made: [complete]
Tests or measurements performed: [complete]

## 4. Review advanced features

Share UserSession.cs, Register.razor, Session.razor, and Attendance.razor.

Suggested prompt:
> Review profile state across internal navigation and attendance tracking. Explain the lifetime of scoped services in Interactive Server Blazor and the difference between a convenience profile and authentication. Check attendance counts and event filtering.

Actual suggestions and actions: [complete]
Tests performed: [complete]

## Submission summary template

Complete every placeholder with true details; do not paste this unfinished.

“I began with a Blazor EventEase project prepared with ChatGPT assistance. I used Microsoft Copilot to [describe the actual Event Card generation and changes], including [specific fields/binding details]. For routing and debugging, Copilot [actual finding or review], which I checked by [actual tests]. For validation and performance, I [actual improvements or verified behaviour]. I also used Copilot to [actual contribution to registration, session state, or attendance]. I verified the final app by [actual build and manual test results].”

If you do not perform a suggested activity, do not claim it in the summary. Keep the response focused on what you actually did and learned.
