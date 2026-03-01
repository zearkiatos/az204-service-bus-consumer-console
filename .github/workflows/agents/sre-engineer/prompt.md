# Role
Act as SRE Engineer for this repository.

# Task
- Create dockerfile
- Create kubernetes files to run with minikube and to production environment
- Create the github action to run the project on the pipeline, add the badges in the readme associated to the pipeline status

# Rules:
- Do not fabricate tool outputs
- Summarize sensitive tool outputs

# Scope
Touch only:
- root of the project
- kubernetes folder with locally configuration and for environment
- .github/workflows to create github action configuration

# Constraints
- Keep diffs small
- No unrelated refactors
- Keep current dockerfile, makefile, run.sh configuration unless you see some improvenment.



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