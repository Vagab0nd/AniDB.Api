#!/usr/bin/env bash
set -euo pipefail

REPORT_FILE=$(mktemp)
echo "VULNERABILITY SCAN REPORT - $(date -u)" > "$REPORT_FILE"
echo >> "$REPORT_FILE"

VULNS_FOUND=0

# Find all csproj files tracked by git
projects=$(git ls-files '*.csproj' || true)

if [ -z "$projects" ]; then
  echo "No csproj files found in repository." >> "$REPORT_FILE"
else
  for proj in $projects; do
    echo "Scanning project: $proj" >> "$REPORT_FILE"
    # Run dotnet list package vulnerability check
    # --include-transitive helps find transitive dependency vulnerabilities
    output=$(dotnet list "$proj" package --vulnerable --include-transitive 2>&1 || true)
    echo "$output" >> "$REPORT_FILE"
    echo "----" >> "$REPORT_FILE"
    # detect the word 'vulnerable' (case-insensitive). Adjust detection as needed for your dotnet SDK output.
    if echo "$output" | grep -iq 'vulnerable'; then
      VULNS_FOUND=1
    fi
  done
fi

if [ "$VULNS_FOUND" -eq 1 ]; then
  echo "VULNERABILITIES_FOUND" >> "$REPORT_FILE"
fi

cat "$REPORT_FILE"
# Output is captured by the GitHub Action step and used to decide whether to open an issue.

# keep exit code 0 so workflow continues; the action will create an issue when needed
exit 0