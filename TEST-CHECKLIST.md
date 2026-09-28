# Pre-submission checklist

Preparation status: source reviewed; .NET compilation and browser tests not run in the preparation environment. Complete these checks locally. Use fictional attendee details only.

- [ ] `dotnet restore` succeeds.
- [ ] `dotnet build` succeeds with no errors.
- [ ] `dotnet run --urls http://localhost:5075` starts successfully.
- [ ] Home displays three event cards, dates, locations, and navigation.
- [ ] Search finds matches by name and location; unmatched input gives a helpful message.
- [ ] Edit an event name, location, and date; save updates the card and details page.
- [ ] Cancel an edit; the saved event remains unchanged.
- [ ] Empty event name/location is rejected.
- [ ] Event links navigate to the corresponding details and registration pages.
- [ ] Direct visits to `/events/999`, `/events/abc`, `/register/999`, and `/wrong-page` give a recovery link without crashing.
- [ ] Empty registration fields and invalid email formats are rejected.
- [ ] Register Test Attendee / learner@example.com for the first event; confirmation appears and booked places increase by one.
- [ ] Return using internal navigation and try the same email for the same event with different capitalisation; duplicate is rejected and count stays unchanged.
- [ ] Register that email for a different event; registration is allowed.
- [ ] Name and email fill automatically on the second registration page.
- [ ] My session shows the last registered profile. Clearing it removes prefill on the next visit but retains registrations.
- [ ] Attendance shows the entries; checking/unchecking one changes registered/checked-in/awaiting counts correctly.
- [ ] Filtering attendance by event limits rows and counters to that event.
- [ ] To test capacity quickly, temporarily set the first event's Capacity to 1 in EventStore.cs, restart, register one attendee, then try another on `/register/1`; it is rejected. Restore Capacity to 40 and rebuild afterwards.
- [ ] A full reload resets demo data as documented. A new independent browser session has its own state.
- [ ] Keyboard navigation, input labels, and focus outlines work; layout remains usable at a narrow window width.
- [ ] Copilot worklog contains actual actions and results, without placeholders or invented claims.
- [ ] Public GitHub repository includes the source folders, project file, and README.
- [ ] Submitted URL opens the public repository when signed out.

Record actual build output and any failures/fixes below:

[Complete after testing.]
