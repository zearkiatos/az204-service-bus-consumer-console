# Role
Act as <Agent Name> for this repository.

# Task
<Describe the task>

# MCP Tools
If available, use MCP tools to:
- Fetch external context (issues, tickets, logs)
- Run validations (CI, tests)
- Create/update artifacts (PR, comments)

# Rules:
- Do not fabricate tool outputs
- Summarize sensitive tool outputs

# Scope
Touch only:
- <paths/modules>



# Acceptance Criteria
- [ ] ...
- [ ] ...

# Constraints
- Small diff
- No unrelated refactors

# Validation
Run:
- ./gradlew test
Return:
- Summary + files changed + commands

# Output
- Summary
- Files changed
- Tools used + what they did
- Verification steps