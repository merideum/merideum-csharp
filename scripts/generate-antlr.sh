#!/bin/bash

grammarName="Merit.g4"

rm -r ./Merideum.Merit/Antlr

java -Xmx500M -cp "/usr/local/lib/antlr-4.10.1-complete.jar:$CLASSPATH" org.antlr.v4.Tool -Dlanguage=CSharp -visitor -o ./Merideum.Merit/Antlr -package Merideum.Merit.Antlr Merit.g4

echo "Generated C# ANTLR classes for grammar $grammarName"