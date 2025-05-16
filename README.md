This project will provide RESTful web service endpoints to support the Referral Program for the Carton Caps App. The App will keep track of whether a user invited their friend by Text, Email or Share. An assumption is being made that the Share dialog can track whether the user Shared the invite by starting a Text or Email. These will be critical pieces of data as it will be used in a future update to tie the referral from the tracking table to the user's account, where credit will be applied.

In its current state, this application will be using a SQLite database to store the tracking information. If this database does not exist, the code will automatically create a database in the machine's "special" directory.

For Windows 11 this is: C:\Users\<user_dir>\AppData\Local

Unit Tests are in place, but are very limited and will be built out as business logic is added to the code.

Existing Calls
* GetFriendsList
* ApplyReferralCredit (Stubbed out method)
* RecordReferralInviteSent
* GetReferralLink

Next Steps
* Talk to the stakeholders to dive deeper into business needs
* Review existing architecture and functionality to make certain we are following shop best practices
* Begin the next round of coding / refactoring!

Be sure to Restore NuGet packages before building / running.
* Unit Testing uses xUnit and Moq
* CartonCapsService uses EF Core and SQLite
