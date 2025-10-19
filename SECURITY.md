# Security policy

## Reporting a Vulnerability

If you discover a security vulnerability in this repository or in packages published from it, please follow these steps:

1. Notify the maintainers privately: open a confidential GitHub Security Advisory (recommended) or email the maintainer at the address listed on the repository's profile.
2. Include:
   - A clear description of the issue, steps to reproduce, and affected versions.
   - A suggested fix or mitigation, if available.
   - Proof-of-concept or exploit details only when necessary for verification.

We will acknowledge receipt within 48 hours and provide a timeline for a fix.

## Supported Versions

- We actively support the latest release on the `main` branch and the most recent patch line(s) defined in repository documentation.
- Older releases may be supported only for critical security fixes. If a fix cannot be provided, affected package versions will be deprecated on nuget.org and users will be advised to upgrade.

## How we handle vulnerabilities

- We triage and fix confirmed vulnerabilities as quickly as possible.
- Patches will be released and published to nuget.org.
- If a release is not going to be patched, we will mark it as deprecated on nuget.org and provide migration instructions.

## Public timeline and advisories

Security fixes will include:
- CVE identifiers if issued.
- Release notes describing the vulnerability and mitigation.
- Guidance on minimum safe versions.