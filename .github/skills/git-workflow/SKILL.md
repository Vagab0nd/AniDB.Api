---
name: git-workflow
description: Apply this skill when creating commits, managing branches, discussing Git workflows, or performing Git operations. Activate when working with version control, creating pull requests, or reviewing Git history.
---

# Git Workflow

## Branch Strategy
- `main`: Production-ready code
- `{description}` (e.g., `add-login-feature` or `net10-support`)

## Commit Messages
Follow conventional commits format:
```
brief description

Detailed explanation of changes:
- What was changed
- Why it was changed
- Any breaking changes

Co-Authored-By: Claude <noreply@anthropic.com>
```

## Branch Lifecycle
1. Create feature branch from `main`
2. Make changes and commit regularly
3. Push branch to remote
4. Create pull request
5. Code review and approval
6. Merge to `main`
7. Delete feature branch

## Pull Request Best Practices
- Keep PRs focused and small (< 400 lines ideal)
- Write clear PR description
- Link related issues
- Ensure CI/CD passes
- Request reviews from appropriate reviewers
- Respond to review feedback promptly
- **ALWAYS** use `pull_request_template.md`

## Git Best Practices
- Commit early and often
- Write clear commit messages
- Never commit secrets or credentials
- Use `.gitignore` appropriately
- Pull before pushing
- Don't force push to shared branches